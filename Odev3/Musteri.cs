using System;
using System.Collections.Generic;
using System.Text;

namespace Odev3
{
    enum Burc
    {
        YENGEC,
        BALIK,
        ASLAN
    }
    class Musteri
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public int Yasi { get; set; }
        public Burc Burcu { get; set; } 
       
    }
}
