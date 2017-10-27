using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Sale
    {
        public int ID { get; set; }
        public string RashodDate { get; set; }
        public string RashodTime { get; set; }
        public bool Done { get; set; }
        public bool Nal { get; set; }
        public Staff Staff { get; set; }
        public Client Client { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal MoneyRec { get; set; }
        public string VISA { get; set; }
        public double TotalItems { get; set; }
        public bool Fiscal { get; set; }
        public List<Product> Products { get; set; }

        public Sale()
        {
            Staff = new Staff();
            Client = new Client();
            Products = new List<Product>();
            Nal = true;
        }

        public Sale(string date, string time, bool done, bool nal, int staffID, int clientID, decimal totalAmmount, decimal moneyRec, string visa, float totItems, bool fisc)
            : this (0, date, time, done, nal, staffID, clientID, totalAmmount, moneyRec, visa, totItems, fisc)
        {
            
        }

        public Sale(int id, string date, string time, bool done, bool nal, int staffID, int clientID, decimal totalAmmount, decimal moneyRec, string visa, float totItems, bool fisc)
        {
            ID = id;
            RashodDate = date;
            RashodTime = time;
            Done = done;
            Nal = nal;
            Staff.ID = staffID;
            Client.ID = clientID;
            TotalAmount = totalAmmount;
            MoneyRec = moneyRec;
            VISA = visa;
            TotalItems = totItems;
            Fiscal = fisc;
        }
    }
}
