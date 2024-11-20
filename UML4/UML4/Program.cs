using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML4
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class siparis
    {
        public DateTime tarih { get; set; }
         public String durum { get; set; }
        public siparis(DateTime tarih, string durum)
        {
            this.tarih = tarih;
            this.durum = durum;

        }

    }
    public class urun{
        public string ad { get; set; }
        public string telefon { get; set; }
        public urun(string ad, string telefon)
        {
            this.ad = ad;
            this.telefon = telefon;
        }
        public siparis siparisVer()
        {
            return new siparis(DateTime.Now, "Hazırlanıyor");
        }
    }

}
