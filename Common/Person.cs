using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Staff { get; set; }
        public string Phone { get; set; }
        public string Barcode { get; set; }
        
        public Person()
        {

        }

        public Person(string name, bool staff, string phone, string barcode)
            : this (0, name, staff, phone, barcode)
        {

        }

        public Person(int id, string name, bool staff, string phone, string barcode)
        {
            ID = id;
            Name = name;
            Staff = staff;
            Phone = phone;
            Barcode = barcode;
        }
    }
}
