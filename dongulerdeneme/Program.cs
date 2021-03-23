using System;

namespace dongulerdeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.indirimYuzdesi = 41;
            urun1.urunIsmi = "kiss me more lip tattoo";
            urun1.yeniFiyat = 46.99;
            urun1.eskiFiyat = 79.99;

            Urun urun2 = new Urun();
            urun2.indirimYuzdesi = 41;
            urun2.urunIsmi = "precious curl mascara";
            urun2.yeniFiyat = 52.99;
            urun2.eskiFiyat = 89.99;

            Urun urun3 = new Urun();
            urun3.indirimYuzdesi = 40;
            urun3.urunIsmi = "silk matte liquid lipstick";
            urun3.yeniFiyat = 44.99;
            urun3.eskiFiyat = 74.99;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.indirimYuzdesi+ "  "+ urun.yeniFiyat+ " "+
                    urun.eskiFiyat+ "  "+ urun.urunIsmi);
            }

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].indirimYuzdesi + "  " + urunler[i].yeniFiyat + " " +
                   urunler[i].eskiFiyat + "  " + urunler[i].urunIsmi);
            }

            int x = 0;
            while (x < urunler.Length)
            {
                Console.WriteLine(urunler[x].indirimYuzdesi + "  " + urunler[x].yeniFiyat + " " +
                  urunler[x].eskiFiyat + "  " + urunler[x].urunIsmi);
                x++;
            }
        }
    }

    class Urun
    {
        public int indirimYuzdesi { get; set; }
        public double yeniFiyat { get; set; }
        public double eskiFiyat { get; set; }
        public string urunIsmi { get; set; }
        
    }

}

