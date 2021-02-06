using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1= new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriName= "Şule";
            musteri1.MusteriSurname= "Sarıçiçek";
            musteri1.MusteriTC= "11111111111";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriName = "Burak";
            musteri2.MusteriSurname = "Bilgin";
            musteri2.MusteriTC = "22222222222";

            Musteri musteri3= new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriName = "Efe";
            musteri3.MusteriSurname = "Sarıçiçek";
            musteri3.MusteriTC = "33333333333";

            Musteri[] Musteriler = new Musteri[]{musteri1,musteri2,musteri3};


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.List(musteri3);
            Console.WriteLine("İşleminiz Tamamlandı");


        }
    }
}
