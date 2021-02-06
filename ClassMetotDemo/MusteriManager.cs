using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriName + " "+ musteri.MusteriSurname +" " + "müşterisi eklendi");
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriName + " " + musteri.MusteriSurname + " " + "müşterisi silindi");
        }

        public void List(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriName +" " + musteri.MusteriSurname);
            Console.WriteLine("Müşteriler Listelendi");
        }
    }
}
