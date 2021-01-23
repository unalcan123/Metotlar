using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();    //  ihtiyacKrediManager.Hesapla();
            IKrediManager tasitKrediManager = new TasitKrediManager();       //  tasitKrediManager.Hesapla();
            IKrediManager konutKrediManager = new KonutKrediManager();      //  konutKrediManager.Hesapla();
                               
            BasvuruManager basvuruManager = new BasvuruManager();
            // basvuruManager.BasvuruYap(tasitKrediManager);     //cok onemli bir burasi.....


            List<IKrediManager> krediler = new List<IKrediManager>(){ihtiyacKrediManager,  tasitKrediManager,konutKrediManager};

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
