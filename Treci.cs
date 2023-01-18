using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppztreci
{
    internal class Program
    {
        /*Napišite program koji će zatražiti od korisnika da unese neku rečenicu te će ispisati prvu i zadnju riječ te rečenice.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite rečenicu: ");
            string recenica = Console.ReadLine();
            string[] rijeci = recenica.Split();
            Console.WriteLine(rijeci.First() + " " + rijeci.Last());

            Console.ReadKey();
        }
    }
}
