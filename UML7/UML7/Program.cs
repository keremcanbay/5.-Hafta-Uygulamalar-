using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML7
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Sirket
    {
        public string Ad { get; set; }
        public string Konum { get; set; }
        public List<Calisan> Calisanlar { get; set; }

        public Sirket()
        {
            Calisanlar = new List<Calisan>();
        }

        public void CalisanEkle(Calisan calisan)
        {
            Calisanlar.Add(calisan);
            calisan.Sirket = this;
        }
    }
    public class Calisan
    {
        public string Baslik { get; set; }
        public DateTime YayinTarihi { get; set; }
        public Sirket Sirket { get; set; }

        public void SirketAtama(Sirket sirket)
        {
            Sirket = sirket;
            if (!sirket.Calisanlar.Contains(this))
            {
                sirket.CalisanEkle(this); 
            }
        }
    }

}
