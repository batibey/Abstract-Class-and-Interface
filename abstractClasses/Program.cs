using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClasses
{

    class Program
    {

        public static void yazln(string gelen)
        {
            Console.WriteLine(gelen);
        }


        static void Main(string[] args)
        {
            topla tpl = new topla();
            tpl.sonucYaz();

            cikar ckr = new cikar();
            ckr.sonucYaz();

            Class1 cls = new Class1();
            cls.Selamla("Merhaba");

            Ornek orn = new Ornek();
            orn.X();

            Console.ReadLine();

        }

        

        interface IOrnek
        {
            int X();
            
        }

        class Ornek : IOrnek
        {
            public int X()
            {
                yazln("hello");
                return 0;
                
            }
        }


        abstract class islem
        {
            public abstract void sonucYaz();
        }

        class topla : islem
        {
            public override void sonucYaz()
            {
                void toplama(int s1, int s2)
                {
                    int sonuc = s1 + s2;
                    Console.WriteLine(sonuc);
                    Console.ReadLine();
                }

                toplama(3, 9);
            }
        }

        class cikar : islem
        {
            public override void sonucYaz()
            {
                void cikarma(int s1, int s2)
                {
                    int sonuc = s1 - s2;
                    Console.WriteLine(sonuc);
                    Console.ReadLine();
                }

                cikarma(7, 1);
            }
        }


        
    }
}




    
