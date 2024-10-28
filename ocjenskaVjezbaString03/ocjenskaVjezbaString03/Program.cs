using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocjenskaVjezbaString03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite rečenicu:");
            string unos = Console.ReadLine();

            string[] rečenica = unos.Split(' ');
            string prvariječ = rečenica[0];
            string zadnjariječ = rečenica[rečenica.Length - 1];

            Console.WriteLine("Prva riječ je:" + prvariječ);
            Console.WriteLine("Zadnja riječ je:" + zadnjariječ);

            Console.ReadKey();
        }
    }
}
