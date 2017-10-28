using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessToDataLibrary
{
    public partial class AccessToDataLibrary
    {
        #region Variables
        DataSet _ds;
        public float Quantity { get; set; }
        public decimal Price { get; set; }

        bool _exists;

        Sale sale = new Sale();

        public bool Nal { get { return sale.Nal; } set { sale.Nal = value; } }
        public string VISA { get { return sale.VISA; } set { sale.VISA = value; } }
        public decimal MoneyRec { get { return sale.MoneyRec; } set { sale.MoneyRec = value; } }
        #endregion

        /// <summary>
        /// Поиск продукта по штрихкоду
        /// </summary>
        /// <param name="barcode">Штрихкод товара</param>
        /// <returns>таблица с данными о продукте</returns>
        public DataSet FindProductByBarcode(string barcode)
        {
            string query = "SELECT * FROM PRODUCT WHERE BARCODE='" + barcode + "' OR ID='" + barcode + "'";

            _ds = new DataSet();

            using (SqlConnection con = new SqlConnection(provider.conString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(_ds);
                sale.Products.Add(new Product
                {
                    ID = int.Parse(_ds.Tables[0].Rows[0].ItemArray.GetValue(0).ToString()),
                    FullName = _ds.Tables[0].Rows[0].ItemArray.GetValue(1).ToString(),
                    Name = _ds.Tables[0].Rows[0].ItemArray.GetValue(2).ToString(),
                    Code = _ds.Tables[0].Rows[0].ItemArray.GetValue(3).ToString(),
                    Color = _ds.Tables[0].Rows[0].ItemArray.GetValue(4).ToString(),
                    Size = _ds.Tables[0].Rows[0].ItemArray.GetValue(5).ToString(),
                    Barcode = _ds.Tables[0].Rows[0].ItemArray.GetValue(6).ToString(),
                    Barcode2 = _ds.Tables[0].Rows[0].ItemArray.GetValue(7).ToString(),
                    Price = decimal.Parse(_ds.Tables[0].Rows[0].ItemArray.GetValue(8).ToString())
                });
            }

            return _ds;
        }

        /// <summary>
        /// Поиск имени клиента по базе
        /// </summary>
        /// <param name="barcode">Штрихкод клиента</param>
        /// <returns>Данные о клиенте</returns>
        public DataSet DefineClient(string barcode)
        {
            string query = "Select * FROM PERSON WHERE Barcode='" + barcode + "' AND Staff='False'";

            DataSet ds1 = new DataSet();

            using (SqlConnection con = new SqlConnection(provider.conString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds1);

                if (ds1.Tables[0].Rows.Count > 0)
                {
                    sale.Client.ID = ds1.Tables[0].Rows[0].Field<int>("ID");
                    sale.Client.Name = ds1.Tables[0].Rows[0].Field<string>("Name");
                    sale.Client.Discount = ds1.Tables[0].Rows[0].Field<bool>("Discount");
                    sale.Client.DiscValue = ds1.Tables[0].Rows[0].Field<double>("DiscountValue");
                }
                else
                {
                    sale.Client.ID = 0;
                }
            }

            return ds1;
        }

        /// <summary>
        /// Добавление продукта в таблицу реализации
        /// </summary>
        public void AddProductToRashod()
        {
            int ID = int.Parse(_ds.Tables[0].Rows[0].ItemArray.GetValue(0).ToString());

            string query = "INSERT INTO RASHODSUB (RashodID, ProductID, Quantity, Price, TotalAmount) VALUES (@RashodID, @ProductID, @Quantity, @Price, @TotalAmount)";

            DataSet ds1 = new DataSet();
            using (SqlConnection con = new SqlConnection(provider.conString))
            {
                SqlParameter p1 = new SqlParameter("@RashodID", sale.ID);
                SqlParameter p2 = new SqlParameter("@ProductID", ID);
                SqlParameter p3 = new SqlParameter("@Quantity", Quantity);
                SqlParameter p4 = new SqlParameter("@Price", Price);
                SqlParameter p5 = new SqlParameter("@TotalAmount", (decimal)Quantity * Price);

                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddRange(new SqlParameter[5] { p1, p2, p3, p4, p5 });

                SqlDataAdapter da = new SqlDataAdapter(com);

                da.Fill(ds1);
            }
        }

        /// <summary>
        /// Изменение кол-ва товара в чеке
        /// </summary>
        /// <param name="id">ID товара</param>
        /// <param name="q">Новое количество</param>
        public void ChangeQuantityInRashodSub(string id, double q)
        {

            string query = "UPDATE RASHODSUB SET Quantity=" + q + ", TotalAmount=" + q + " * Price WHERE RashodID=" + sale.ID +
                " AND ProductID =" + id;

            DataSet ds1 = new DataSet();

            using (SqlConnection con = new SqlConnection(provider.conString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds1);
            }
        }

        /// <summary>
        /// Вычисление номера текущего чека
        /// </summary>
        /// <returns>номер чека</returns>
        public int GetRashodID()
        {
            string query = "Select * FROM RASHOD WHERE Done='False' AND StaffID=" + sale.Staff.ID;

            DataSet ds1 = new DataSet();

            using (SqlConnection con = new SqlConnection(provider.conString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds1);

                if (ds1.Tables[0].Rows.Count > 0)
                {
                    sale.ID = ds1.Tables[0].Rows[0].Field<int>("Id");
                    _exists = true;
                }
                else
                {
                    query = "Select * FROM RASHOD";

                    da = new SqlDataAdapter(query, con);
                    da.Fill(ds1);

                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        sale.ID = ds1.Tables[0].Rows.Count + 1;
                    }
                    else
                    {
                        sale.ID = 1;
                    }

                    _exists = false;
                }
            }

            return sale.ID;
        }

        /// <summary>
        /// Поиск имени сотрудника по базе
        /// </summary>
        /// <param name="barcode">Штрихкод сотрудника</param>
        /// <returns>имя сотрудника</returns>
        public string GetStaffName(string barcode)
        {
            string query = "Select * FROM PERSON WHERE Barcode='" + barcode + "' AND Staff='True'";

            DataSet ds1 = new DataSet();

            using (SqlConnection con = new SqlConnection(provider.conString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds1);

                if (ds1.Tables[0].Rows.Count > 0)
                {
                    sale.Staff.ID = ds1.Tables[0].Rows[0].Field<int>("ID");
                    return ds1.Tables[0].Rows[0].Field<string>("Name");
                }
                else
                {
                    sale.Staff.ID = 0;
                    return "";
                }
            }
        }

        /// <summary>
        /// Совершение покупки
        /// </summary>
        public void PerformSale()
        {
            sale.Done = true;

            CountTotal();

            sale.RashodDate = DateTime.Now.Date.ToShortDateString();
            sale.RashodTime = DateTime.Now.ToShortTimeString();

            PerformSaleUpdateRashod();
            PerformSaleUpdateStock();

            sale.ID = 0;
        }

        /// <summary>
        /// Внесение изменений в таблицу STOCK при совершении покупки
        /// </summary>
        private void PerformSaleUpdateStock()
        {
            string query = "";

            using (SqlConnection con = new SqlConnection(provider.conString))
            {
                con.Open();

                for (int i = 0; i < sale.Products.Count; i++)
                {
                    query = "UPDATE STOCK SET Quantity=Quantity-1 WHERE ProductID=" + sale.Products[i].ID;

                    SqlCommand com = new SqlCommand(query,con);
                    com.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Обновить данные в таблице RASHOD
        /// при совершении покупки или сохранении нерасчитанного чека
        /// </summary>
        private void PerformSaleUpdateRashod()
        {
            string query = "";

            if (_exists)
            {
                query = "UPDATE RASHOD SET RashodDate='" + sale.RashodDate + "',RashodTime='" + sale.RashodTime + "',Done='" +
                        sale.Done + "',Nal='" + sale.Nal +
                        "',ClientID=" + sale.Client.ID + ",TotalAmount=@TotSum,MoneyRec=" + sale.MoneyRec + ",VISA='" +
                        sale.VISA + "',TotalItems=" + sale.TotalItems + " WHERE ID=" + sale.ID;
            }
            else
            {
                query = "INSERT INTO RASHOD VALUES (" + sale.ID + ",'" + sale.RashodDate + "','" + sale.RashodTime + "','" +
                        sale.Done + "','" + sale.Nal + "'," +
                        sale.Staff.ID + "," + sale.Client.ID + ",@TotSum," + sale.MoneyRec + ",'" + sale.VISA + "'," +
                        sale.TotalItems + ",'False')";
            }

            DataSet ds1 = new DataSet();

            using (SqlConnection con = new SqlConnection(provider.conString))
            {
                SqlParameter p1 = new SqlParameter("@TotSum", sale.TotalAmount);

                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.Add(p1);

                SqlDataAdapter da = new SqlDataAdapter(com);

                da.Fill(ds1);
            }
        }

        /// <summary>
        /// Сохранить незакрытый чек
        /// </summary>
        public void SaveSaleToRashod()
        {
            sale.Done = false;
            sale.Nal = false;

            CountTotal();

            sale.RashodDate = DateTime.Now.Date.ToShortDateString();
            sale.RashodTime = DateTime.Now.ToShortTimeString();

            PerformSaleUpdateRashod();
        }

        /// <summary>
        /// Подсчет общего кол-ва единиц и суммы в отдельном чеке
        /// </summary>
        private void CountTotal()
        {
            string query = "Select * FROM RASHODSUB WHERE RashodID='" + sale.ID + "'";

            DataSet ds1 = new DataSet();

            using (SqlConnection con = new SqlConnection(provider.conString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds1);

                foreach (DataRow row in ds1.Tables[0].Rows)
                {
                    sale.TotalItems += row.Field<double>("Quantity");
                    sale.TotalAmount += row.Field<decimal>("TotalAmount");
                }
            }
        }

        /// <summary>
        /// Поиск по таблице продаж на наличие открытого чека
        /// </summary>
        /// <returns>Таблица с товарами</returns>
        public DataSet ScanRashodSub()
        {
            string query = "SELECT RS.RashodID,R.StaffID,P.FullName,RS.Quantity,RS.Price,P.Price,RS.ProductID,P.DiscountValue FROM RASHODSUB as RS LEFT JOIN RASHOD as R ON RS.RashodID = R.ID LEFT JOIN PRODUCT as P ON RS.ProductID = P.Id WHERE RS.RashodID=" + sale.ID;

            DataSet ds1 = new DataSet();

            using (SqlConnection con = new SqlConnection(provider.conString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds1);
                foreach (DataRow row in ds1.Tables[0].Rows)
                {
                    FillProductList(row.Field<int>("ProductID"));
                }
            }

            return ds1;
        }

        /// <summary>
        /// Заполнение списка продуктов текущего сохраненного чека
        /// </summary>
        /// <param name="id">ID товара</param>
        private void FillProductList(int id)
        {
            string query = "SELECT * FROM PRODUCT WHERE ID=" + id;

            DataSet ds1 = new DataSet();

            using (SqlConnection con = new SqlConnection(provider.conString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds1);

                sale.Products.Add(new Product
                {
                    ID = int.Parse(ds1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString()),
                    FullName = ds1.Tables[0].Rows[0].ItemArray.GetValue(1).ToString(),
                    Name = ds1.Tables[0].Rows[0].ItemArray.GetValue(2).ToString(),
                    Code = ds1.Tables[0].Rows[0].ItemArray.GetValue(3).ToString(),
                    Color = ds1.Tables[0].Rows[0].ItemArray.GetValue(4).ToString(),
                    Size = ds1.Tables[0].Rows[0].ItemArray.GetValue(5).ToString(),
                    Barcode = ds1.Tables[0].Rows[0].ItemArray.GetValue(6).ToString(),
                    Barcode2 = ds1.Tables[0].Rows[0].ItemArray.GetValue(7).ToString(),
                    Price = decimal.Parse(ds1.Tables[0].Rows[0].ItemArray.GetValue(8).ToString())
                });
            }
        }

        /// <summary>
        /// удаление товара из открытого чека
        /// </summary>
        /// <param name="id">товар</param>
        public void RemoveItemFromRashod(int id)
        {
            string query = "DELETE FROM RASHODSUB WHERE RashodID=" + sale.ID +
                " AND ProductID IN(SELECT P.Id FROM RASHODSUB as RS LEFT JOIN PRODUCT as P ON RS.ProductID=P.Id WHERE P.Id=" + id + ")";

            using (SqlConnection con = new SqlConnection(provider.conString))
            {
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
            }

            for (int i = 0; i < sale.Products.Count; i++)
            {
                if (sale.Products[i].ID == id)
                {
                    sale.Products.RemoveAt(i);
                    --i;
                }
            }
        }

        /// <summary>
        /// Печать чека
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <param name="table">Таблица для заполнения</param>
        /// <returns></returns>
        public DataSet PrintBill(string query, string table)
        {
            DataSet ds1 = new DataSet();

            using (SqlConnection con = new SqlConnection(provider.conString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds1, table);
            }

            return ds1;
        }

        /// <summary>
        /// Изменить кол-во единиц конкретного товара в открытом чеке
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="quantity">Новое количество</param>
        /// <param name="price">Цена товара</param>
        public void UpdateQuantity(int id, double quantity, decimal price)
        {
            string query = "UPDATE RASHODSUB SET Quantity=@Quantity,Price=@Price,TotalAmount=@TotalAmount WHERE RashodID=@RashodID AND ProductID=@ProductID";

            DataSet ds1 = new DataSet();
            using (SqlConnection con = new SqlConnection(provider.conString))
            {
                SqlParameter p1 = new SqlParameter("@RashodID", sale.ID);
                SqlParameter p2 = new SqlParameter("@ProductID", id);
                SqlParameter p3 = new SqlParameter("@Quantity", quantity);
                SqlParameter p4 = new SqlParameter("@Price", price);
                SqlParameter p5 = new SqlParameter("@TotalAmount", (decimal)quantity * price);

                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddRange(new SqlParameter[5] { p1, p2, p3,p4, p5 });

                SqlDataAdapter da = new SqlDataAdapter(com);

                da.Fill(ds1);
            }
        }

        /// <summary>
        /// Подсчет дневного выторга
        /// </summary>
        /// <param name="date">Дата</param>
        /// <returns></returns>
        public DataSet CountMoney(string date)
        {
            string query = "SELECT SUM(R.TotalAmount) as Total, (SELECT Sum(TotalAmount) FROM RASHOD WHERE RashodDate='" + date +
                "' AND Nal='True') as NAL, (SELECT Sum(TotalAmount) FROM RASHOD WHERE RashodDate = '" + date +
                "' AND Nal = 'FALSE') AS VISA From RASHOD as R WHERE r.RashodDate = '" + date + "' ";

            DataSet ds1 = new DataSet();

            using (SqlConnection con = new SqlConnection(provider.conString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds1);
            }

            return ds1;
        }

        /// <summary>
        /// Проверка групп товаров на дополнительную скидку
        /// </summary>
        /// <param name="id">ID товара</param>
        /// <returns></returns>
        public DataSet GroupCheck(string id)
        {
            string query = "SELECT G.Akciya, G.AkciyaValue FROM PRODUCT as P JOIN GROUPS as G ON P.SubGroupID=G.Id WHERE P.ID=" + id;

            DataSet ds1 = new DataSet();

            using (SqlConnection con = new SqlConnection(provider.conString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds1);
            }

            return ds1;
        }

        /// <summary>
        /// Поиск разновидностей по модели
        /// </summary>
        /// <returns></returns>
        public List<string> CheckSameModel()
        {
            string query =
                "SELECT P.FullName, S.Quantity FROM PRODUCT as P INNER JOIN STOCK as S ON P.Id = S.ProductID WHERE P.Code = '" +
                sale.Products[sale.Products.Count - 1].Code + "'";

            DataSet ds1 = new DataSet();

            using (SqlConnection con = new SqlConnection(provider.conString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds1);
            }

            List<string> res = new List<string>();

            foreach (DataRow row in ds1.Tables[0].Rows)
            {
                res.Add(row.ItemArray.GetValue(0).ToString() + "      " + row.ItemArray.GetValue(1).ToString());
            }

            return res;
        }

        /// <summary>
        /// Поиск чека продажи для операции "Возврат"
        /// </summary>
        /// <param name="saleID">Номер чека продажи</param>
        /// <returns></returns>
        public DataSet DefineReturnSale(string saleID)
        {
            string query =
                "SELECT R.ID, P.ID, P.FullName, RS.Price, RS.Quantity, RS.TotalAmount, R.Nal, R.TotalAmount, R.VISA, PS.Name, PS.DiscountValue" + 
                " FROM RASHOD as R INNER JOIN RASHODSUB as RS ON R.Id = RS.RashodID INNER JOIN PRODUCT as P ON RS.ProductID = P.Id" +
                " LEFT JOIN PERSON as PS ON R.ClientID = PS.ID WHERE R.Id = '" + saleID + "'";

            DataSet ds1 = new DataSet();

            using (SqlConnection con = new SqlConnection(provider.conString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds1);
            }

            return ds1;
        }
    }
}