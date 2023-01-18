using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppzprvi
{
    /*1.
Napišite program u kojem ćete deklarirati varijable a, b, c, i d tipa double, 
te im dodijelite proizvoljne vrijednosti. Deklarirajte varijablu x tipa double kojoj dodijelite vrijednost 
sljedećeg matematičkog izraza:a2 + b2 + c2 + d2*/
    internal class Program
    {
        static void Main(string[] args)
        {
            double a=1, b=2, c=3, d=4;
            double x=(a*2 + b*2 + c*2 + d*2)/ (a + b)*2 + (c + d)*2;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
