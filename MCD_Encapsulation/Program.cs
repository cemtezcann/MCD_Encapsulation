using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            /*Field deger ataması yapılsın ama deger okunabilsin
             * Field deger ataması yapılsın ama deger okunamasın
             * field deger ataması yapılsın ama degerin ilk 4hanesi okunsun
             * field deger atamsı ve okuma işlemleri yapılsın ama bu iki işlemde bizim
             * belirlediğimiz bir süreçten geçsin veri daha sonra gösterilsin
             * 
             */

            // M1.emailAdres = "turanfaik@asdasdas.com";

            //GEnel olarak kapsülleme konusuna giriş yaptık
            M1.EmailAdres = "turanfaik@asdasdas.com";
            Console.WriteLine(M1.EmailAdres);
        }
    }
}
