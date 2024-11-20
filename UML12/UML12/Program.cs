using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML12
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Islemci
    {
        public int Cekirdekler { get; set; }
        public int Frekans { get; set; } // MHz cinsinden

        public Islemci(int cekirdekler, int frekans)
        {
            Cekirdekler = cekirdekler;
            Frekans = frekans;
        }

        public string IslemciBilgisi()
        {
            return $"Çekirdek Sayısı: {Cekirdekler}, Frekans: {Frekans} MHz";
        }
    }

    public class Bilgisayar
    {
        public string Model { get; set; }
        public Islemci Islemci { get; private set; }

        public Bilgisayar(string model)
        {
            Model = model;
        }

        public void IslemciOlustur(int cekirdekler, int frekans)
        {
            Islemci = new Islemci(cekirdekler, frekans);
        }

        
         
    }
}
