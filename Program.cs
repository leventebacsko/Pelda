using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace GitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var mintaTomb = new int[] {100, 1,2,3,5,7,6,10};

            // Minimum keresés
            Console.WriteLine(mintaTomb.Min());

            // Maximum keresés
            Console.WriteLine(mintaTomb.Max());

            // Sorbarendezés
            mintaTomb.OrderBy(x=>x).ToList().Output("Sorba rendezett");

            mintaTomb.OrderByDescending(x=>x).ToList().Output("Sorba rendezett csökkenő");
            
            Console.WriteLine("Hello World");
            // Keresés (filter)
            mintaTomb.Where(x=> x<10 ).ToList().Output("Tíznél kisebb elemek");
        }
    }
}
