using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomNumbers();
        }

        static void RandomNumbers()
        {
            Console.WriteLine("MANDATO: Todos los elementos retornados, deben ser menor o igual al " +
                "valor de n y \n mayor a 0 los elementos de la lista deben ser únicos por lo que no deben repetirse.");

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("________________________");
            Random rdm = new Random();

            var range = Enumerable.Range(1, n).OrderBy(i => rdm.Next()).ToList();

            foreach (var item in range)

            {
                Console.WriteLine(item);
            }         

            Console.ReadLine();
        }
    }
}
