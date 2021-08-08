using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class DortIslem
        
    {
        public void Toplama(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);
        }
        public void Cikarma(int sayi1, int sayi2)
        {
            int sonuc;
            if (sayi1 > sayi2)
            {
                 sonuc = sayi1 - sayi2;
                
            }
            else
            {
                sonuc = sayi2 - sayi1;
                Console.WriteLine(sonuc);
            }
            
        }


    }
}
