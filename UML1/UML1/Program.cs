using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public class yazar
        {
            public string ad { get; set; }
            public string ulke { get; set; }
            public List<kitap> Kitaplar { get; set; }
            public void kitapEkle(kitap kitap)
            {
                Kitaplar.Add(kitap);
            }
            public yazar(string ad, string ulke)
            {
                this.ad = ad;
                this.ulke = ulke;
                Kitaplar = new List<kitap>();

            }
        }
    }
        public class kitap
        {
             public string baslik { get; set; }
            public string ISBN { get; set; }
            public kitap(string baslık, string ISBN)
            {
                this.baslik = baslik;
                this.ISBN = ISBN;
            }
        }
}
