using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Fatma";
            musteri1.Soyadi = "Arslan";
            musteri1.TcNo = "123456789";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "123456";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();



            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            Console.WriteLine(musteri1.Id);

            Class1 class1 = new Class1();
            



        }
    }
}
