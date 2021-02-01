using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ıd = 1;
            musteri1.Ad = "Merve";
            musteri1.Soyad = "Çakıroğlu";
            musteri1.iletisimNo = 12345;

            Musteri musteri2 = new Musteri();
            musteri2.ıd = 2;
            musteri2.Ad = "Gönül";
            musteri2.Soyad = "Çakıroğlu";
            musteri2.iletisimNo = 23456;

            Musteri musteri3 = new Musteri();
            musteri3.ıd = 3;
            musteri3.Ad = "Alimuz";
            musteri3.Soyad = "Çakıroğlu";
            musteri3.iletisimNo = 34567;

            Musteri[] musteriler = new[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.ıd);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.iletisimNo);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriSilme(musteri1);
            musteriManager.MusteriSilme(musteri3);


        }
    }
}
