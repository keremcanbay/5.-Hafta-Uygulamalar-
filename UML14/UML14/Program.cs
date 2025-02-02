﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML14
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Ogrenci
    {
        public string Ad { get; set; }
        public int Yas { get; set; }

        public Ogrenci(string ad, int yas)
        {
            Ad = ad;
            Yas = yas;
        }

        public string OgrenciBilgisi()
        {
            return $"Ad: {Ad}, Yaş: {Yas}";
        }
    }

    public class Okul
    {
        public string Ad { get; set; }
        public List<Ogrenci> Ogrenciler { get; private set; }

        public Okul(string ad)
        {
            Ad = ad;
            Ogrenciler = new List<Ogrenci>();
        }

        public void OgrenciOlustur(string ad, int yas)
        {
            Ogrenciler.Add(new Ogrenci(ad, yas));
        }

    }
}
