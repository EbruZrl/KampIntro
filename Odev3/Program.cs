using System;

namespace Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Ebru";
            musteri1.Yasi = 20;
            musteri1.Burcu = Burc.YENGEC;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Fatma";
            musteri2.Yasi = 20;
            musteri2.Burcu = Burc.YENGEC;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Aşkın";
            musteri3.Yasi = 21;
            musteri3.Burcu = Burc.BALIK;

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Yasi);
                Console.WriteLine(musteri.Burcu);

            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekleme(musteri1);
            musteriManager.Ekleme(musteri2);
            musteriManager.Ekleme(musteri3);

            MusteriManager musteriManager2= new MusteriManager();
            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Silme(musteri3);

            MusteriManager musteriManager3= new MusteriManager();
            musteriManager.Listeleme(musteri1);
            musteriManager.Listeleme(musteri2);
            musteriManager.Listeleme(musteri3);




        }
    }
}
