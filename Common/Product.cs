using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Product 
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Barcode { get; set; }
        public string Barcode2 { get; set; }
        public decimal Price { get; set; }

        public Product()
        {

        }

        public Product(string fullName, string name, string code, string color, string size, string barcode, string barcode2, decimal price)
            : this (0, fullName, name, code, color, size, barcode, barcode2, price)
        {

        }

        public Product(int id, string fullName, string name, string code, string color, string size, string barcode, string barcode2, decimal price)
        {
            ID = id;
            FullName = fullName;
            Name = name;
            Code = code;
            Color = color;
            Size = size;
            Barcode = barcode;
            Barcode2 = barcode2;
            Price = price;
        }
    }
}
