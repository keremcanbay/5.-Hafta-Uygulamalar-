using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML11
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Kitap
    {
        public string Baslik { get; set; }
        public string Yazar { get; set; }

        public Kitap(string baslik, string yazar)
        {
            Baslik = baslik;
            Yazar = yazar;
        }

       
    }

    public class Kutuphane
    {
        public string Ad { get; set; }
        public List<Kitap> Kitaplar { get; private set; }

        public Kutuphane(string ad)
        {
            Ad = ad;
            Kitaplar = new List<Kitap>();
        }

        public void KitapEkle(Kitap kitap)
        {
            Kitaplar.Add(kitap);
        }

       
        }
    }
}
