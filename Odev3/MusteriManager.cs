using System;
using System.Collections.Generic;
using System.Text;

namespace Odev3
{
    class MusteriManager
    {
        public void Ekleme (Musteri musteri) 
        {
            Console.WriteLine(musteri.Adi + "eklendi");
        }
        public void Listeleme (Musteri musteri)
        {
            Console.WriteLine(musteri.Adi);
        }     
        public void Silme (Musteri musteri)
        {
            Console.WriteLine (musteri.Adi + "Silindi" );
        }
    }
}
