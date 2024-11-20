using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML9
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Ev
    {
        // Özellikler
        public string Ad { get; set; }
        public List<Oda> Odalar { get; private set; } = new List<Oda>();

        // Yöntemler
        public void OdaEkle(Oda oda)
        {
            if (oda != null)
            {
                Odalar.Add(oda);
            }
        }
    }

    public class Oda
    {
        // Özellikler
        public string Boyut { get; set; }
        public string Tip { get; set; }

        // Yapıcı Metod
        public Oda(string boyut, string tip)
        {
            Boyut = boyut;
            Tip = tip;
        }
    }
}
