using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1_side16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input "decimaltal"
            Console.WriteLine("Indtast decimaltal");
            decimal decimaltal = decimal.Parse(Console.ReadLine());

            //Input bliver rundet op til et hel tal
            decimaltal = Math.Round(decimaltal);

            //Her bliver decimaltal converted til en "int" altså "hel tal"
            int resultat = Convert.ToInt32(decimaltal);

            //Udskrivning af "resultat" + tekst
            Console.WriteLine(resultat + " Tallet bliver rundet op");

            //Slut
            Console.ReadKey();
        }
    }
}
