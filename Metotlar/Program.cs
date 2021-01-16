using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elmasi";
           
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
            }



            Console.WriteLine("--------------metotlar------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            //sepetManager.Ekle();
            // sepetManager.Ekle();

            sepetManager.Ekle2("Armut", "yesil Armut", 12,100);
            sepetManager.Ekle2("Elma", "yesil Elma", 12,500);
            sepetManager.Ekle2("Karpuz", "Diyabakir karpuzu", 12,250);
        }

        
    }
}
