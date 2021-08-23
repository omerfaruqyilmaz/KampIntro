using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {


            Urun urun1 = new Urun();
            urun1.Adi = "Erik";
            urun1.Fiyati = 29.5;
            urun1.Aciklama = "Papaz eriği";
            urun1.StokAdedi = 25;

            Urun urun2 = new Urun();
            urun2.Adi = "Ejder meyvesi";
            urun2.Fiyati = 100.5;
            urun2.Aciklama = "Senegalden özenle seçildi";
            urun2.StokAdedi = 54;

            Urun[] urunler = new Urun[] {urun1, urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("************");
            }

            Console.WriteLine("----------Metotlar---------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun1);


            
            

        }
    }
}



//Dont repeat yourself-DRY-Clean Code-Best Practice