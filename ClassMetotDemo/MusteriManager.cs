using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Musteriyi Eklediniz : " + musteri.Ad);

        }
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Musteri Listelendi : " + musteri.Ad + " " + musteri.Soyad);

        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Musteri Silindi : " + musteri.ıd + " " + musteri.Ad + " " + musteri.Soyad);

        }
    }
}
