using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + musteri.MusteriSoyadi + ", İsimli müşteri eklendi.");
        }
        
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + musteri.MusteriSoyadi + ", İsimli müşteri silindi.");
        }
    }
}
