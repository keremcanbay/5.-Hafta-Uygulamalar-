using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML10
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Sirket
    {
        // Özellikler
        public string Ad { get; set; }
        public List<Calisan> Calisanlar { get; set; } = new List<Calisan>();

        // Yöntemler
        public void CalisanEkle(Calisan calisan)
        {
            if (calisan != null && !Calisanlar.Contains(calisan))
            {
                Calisanlar.Add(calisan); // Listeye çalışanı ekle
            }
        }
    }

    public class Calisan
    {
        // Özellikler
        public string Ad { get; set; }
        public string Pozisyon { get; set; }

        // Yöntemler
        public string CalisanBilgisi()
        {
            return $"{Ad} - {Pozisyon}";
        }
    }
}
