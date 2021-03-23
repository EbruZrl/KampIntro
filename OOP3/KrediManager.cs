using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlarda kullanırız.

    interface IKrediManager //okunurluk arttırmak için I koyuyoruz interface önüne
    {

        void Hesapla();
        void BirSeyYap();
        
    }
}
