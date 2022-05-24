using System;

namespace Digitron
{ class Program {

        static void Main(string[] args)
        {


            Console.WriteLine("#--------------------#");


            Console.WriteLine("Unesite prvi broj");

            string privBroj = Console.ReadLine();
            float pbroj = Convert.ToInt32(privBroj);

            Console.WriteLine("Unesite drugi broj ");
            string drugiBroj = Console.ReadLine();
            float dbroj = Convert.ToInt32(drugiBroj);


            Console.WriteLine("#------------------#");

            Console.WriteLine("Tip Podatka: "  + pbroj.GetType()+ " Vrednost:"+ pbroj);
            Console.WriteLine("Tip Podatka: " + dbroj.GetType() + " Vrednost:" + dbroj);


            Console.WriteLine("Sab: " +(pbroj + dbroj));
            Console.WriteLine("Odu: " +(pbroj - dbroj) );
            Console.WriteLine("Mno: " + (pbroj * dbroj));
            Console.WriteLine("Del: " + (pbroj / dbroj));
            Console.WriteLine("Mod: " + (pbroj % dbroj));





        }
    
    
    }







     }
