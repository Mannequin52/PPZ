using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppzdrugi
{
    /*2. 
Napišite program u kojem ćete definirati sljedeće dvije varijable tipa string:
• s1 sa sadržajem "Hrvatska ima more"
• s2 sa sadržajem "Italija je prvak svijeta"
Definirajte i ispišite string s3 čiji će sadržaj biti prvih 8 znakova stringa s1 plus svi znakovi od sedmog do kraja niza s2.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hrvatska ima more";
            string s2 = "Italija je prvak svijeta";

            Console.WriteLine(s1.Substring(0, 8) + s2.Substring(7, s2.Length - 7));

            Console.ReadKey();
        }
    }
}
