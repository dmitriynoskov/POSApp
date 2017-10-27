using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public enum POSITION
    {
        ADMIN,
        CASHIER
    }

    public class Staff : Person
    {
        public POSITION Position { get; set; }
        public DateTime PrinyatDate { get; set; }
        public bool Uvolen { get; set; }
        public DateTime UvolenDate { get; set; }
        public bool Vozvrat { get; set; }
        public bool Udalenie { get; set; }
        public decimal Stavka { get; set; }
        
        public Staff(string name, string phone, string barcode, POSITION pos, DateTime prDate, bool uvol, DateTime uvolDate, bool vozv, bool udal, decimal stavka)
            : base(name, true, phone, barcode)
        {
            Position = pos;
            PrinyatDate = prDate;
            Uvolen = uvol;
            UvolenDate = uvolDate;
            Vozvrat = vozv;
            Udalenie = udal;
            Stavka = stavka;
        }

        public Staff()
        {
        }
    }
}
