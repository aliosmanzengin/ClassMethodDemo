using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = "1";
            musteri1.MusteriAdi = "Şemseddin";
            musteri1.MusteriSoyadi = "Sami";

            Musteri musteri2 = new Musteri();
            musteri2.Id = "2";
            musteri2.MusteriAdi = "Şems";
            musteri2.MusteriSoyadi = "Sadi";

            Musteri musteri3 = new Musteri();
            musteri3.Id = "3";
            musteri3.MusteriAdi = "Seyfi";
            musteri3.MusteriSoyadi = "Satılmış";

            Musteri musteri4 = new Musteri();
            musteri4.Id = "4";
            musteri4.MusteriAdi = "Şadiye";
            musteri4.MusteriSoyadi = "Samancı";

            Musteri[] musteris = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach (Musteri musteri in musteris)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Musteri Id:  " + musteri.Id);
                Console.WriteLine("Musteri Adi: " +musteri.MusteriAdi);
                Console.WriteLine("Müşteri Soyad:   " + musteri.MusteriSoyadi);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("-----------------------");

            MusteriManager musteriManager = new MusteriManager();
            
            musteriManager.Ekle(musteri2);

            musteriManager.Sil(musteri3);




        }
    }
   

}

