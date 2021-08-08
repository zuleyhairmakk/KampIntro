using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
          
           urun1.UrununAdi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elmasi";

            Urun urun2 = new Urun();
            urun2.UrununAdi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakir karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.UrununAdi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
            }
            Console.WriteLine("--------------metodlar-----");

            SepetManager manage = new SepetManager();
            manage.Ekle(urun1);
            manage.Ekle(urun2);







        }
    }
}
