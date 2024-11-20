using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML8
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Ebeveyn
    {
        // Özellikler
        public string Ad { get; set; }
        public int Yas { get; set; }
        public List<Cocuk> Cocuklar { get; set; } = new List<Cocuk>();

        // Yöntemler
        public void CocukEkle(Cocuk cocuk)
        {
            if (cocuk != null && !Cocuklar.Contains(cocuk))
            {
                Cocuklar.Add(cocuk);
                cocuk.EbeveynAtama(this); // Çocuğun ebeveynini de ayarla
            }
        }
    }

    public class Cocuk
    {
        // Özellikler
        public string Ad { get; set; }
        public int Yas { get; set; }
        public Ebeveyn Ebeveyn { get; private set; }

        // Yöntemler
        public void EbeveynAtama(Ebeveyn ebeveyn)
        {
            if (ebeveyn != null && Ebeveyn != ebeveyn)
            {
                Ebeveyn = ebeveyn;
                ebeveyn.CocukEkle(this); // Ebeveyn listesine kendini ekle
            }
        }
    }
}