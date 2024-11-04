using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5_Kapanıs
{
    public class Araba
    {
        public DateTime UretimTarihi { get; private set; }
        public int SeriNumb { get; set; }
        public string Marka { get; set; }
        public int Model { get; set; }
        public string Renk { get; set; }
        public int KapiSayisi { get; set; }

        public Araba() 
        {
            UretimTarihi = DateTime.Now;// üretim tarihi anlık olarak otomatik atanır
        }

    }
}
