using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML13
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Motor
    {
        public int Guc { get; set; } // Motor gücü (ör. beygir gücü)
        public string Tip { get; set; } // Motor tipi (ör. benzinli, dizel, elektrikli)

        public Motor(int guc, string tip)
        {
            Guc = guc;
            Tip = tip;
        }

        public string MotorBilgisi()
        {
            return $"Güç: {Guc} HP, Tip: {Tip}";
        }
    }

    public class Otomobil
    {
        public string Marka { get; set; } // Otomobil markası
        public Motor Motor { get; private set; }

        public Otomobil(string marka)
        {
            Marka = marka;
        }

        public void MotorOlustur(int guc, string tip)
        {
            Motor = new Motor(guc, tip);
        }

        
          
        }
    
}
