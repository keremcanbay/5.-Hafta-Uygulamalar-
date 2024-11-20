using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class sipariş
    {
        public DateTime tarih { get; set; }
        public decimal toplam { get; set; }
        public sipariş( DateTime tarih,decimal toplam)
        {
            this.tarih = tarih;
            this.toplam = toplam;
        }
    }
    public class urun
    {
        public string ad { get; set; }
        public int fiyat { get; set; }
        public void urunBilgisi()
        {

        }
        public urun(string ad, int fiyat)
        {
            this.ad = ad;
            this.fiyat = fiyat;

        }
    }
}
