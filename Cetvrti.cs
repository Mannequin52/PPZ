using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppzcetvrti
{
    /*Napišite program u kojem ćete zatražiti od korisnika da unese 
     * jedan cijeli i jedan decimalni broj odvojene razmakom. Dvostruke vrijednosti 
     * unešenih brojeva spremite u odgovarajuće varijable x i y, te ih ispišite.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string brojevi;

            Console.WriteLine("Unesite jedan cijeli i jedan decimalni broj odvojeni s razmakom: ");
            brojevi = Console.ReadLine();

            int x;
            double y;

            string[] broj = brojevi.Split(' ');
            x = Convert.ToInt32(broj[0]);
            y = Convert.ToDouble(broj[1]);

            Console.WriteLine("Prvi broj je " + x + " i drugi je " + y);

            Console.ReadKey();
        }
    }
}
