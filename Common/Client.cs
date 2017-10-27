using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Client : Person
    {
        public bool Discount { get; set; }
        public double DiscValue { get; set; }
        public decimal TotalAmount { get; set; }

        public Client(string name, string phone, string barcode, bool disc, float discValue, decimal totAm)
            : base (name, false, phone, barcode)
        {
            Discount = disc;
            DiscValue = discValue;
            TotalAmount = totAm;
        }

        public Client()
        {
        }
    }
}
