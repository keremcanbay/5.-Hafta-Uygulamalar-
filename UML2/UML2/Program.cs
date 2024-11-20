using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class calisan
    {
        public string ad { get; set; }
        public string pozisyon {get;set;}
        public Departman Departman { get; set; }
        public void DepartmanAtama(Departman departman)
        {
            Departman = departman;
        }
        public calisan(string ad,string pozisyon)
        {
            this.ad = ad;
            this.pozisyon = pozisyon;
                
        }

}
    public class Departman
    {
        public string ad { get; set; }
        public string lokasyon { get; set; }
        public Departman(string ad, string lokasyon)
        {
            this.ad = ad;
            this.lokasyon = lokasyon;

        }
    }
