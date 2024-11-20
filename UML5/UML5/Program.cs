using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML5
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Doktor
    {
        public string Ad { get; set; }
        public string Brans { get; set; }
        public List<Hasta> Hastalar { get; set; }

        public Doktor()
        {
            Hastalar = new List<Hasta>();
        }

        public void HastaEkle(Hasta hasta)
        {
            Hastalar.Add(hasta);
            hasta.Doktor = this; 
        }
    }
    public class Hasta
    {
        public string Ad { get; set; }
        public string TCNo { get; set; }
        public Doktor Doktor { get; set; }

        public void DoktorAtama(Doktor doktor)
        {
            Doktor = doktor;
            if (!doktor.Hastalar.Contains(this))
            {
                doktor.HastaEkle(this); // Doktorun hasta listesine ekle
            }
        }
    }
}
