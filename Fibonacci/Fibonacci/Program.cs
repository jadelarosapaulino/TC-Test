using System;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci_Funct();
        }

        static void Fibonacci_Funct()
        {
            int top, a = 0, b = 1, c = 0, count = 0;

            Console.WriteLine("MANDATO: Cree una función que reciba un numero entero n, " +
                "dicha función \n debe retornar los n primeros números de la Sucesión de Fibonacci.");
            top = int.Parse(Console.ReadLine());
            Console.WriteLine("_________________________________");

            for (int i = 0; i <= top; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("{0}", a);
                }
                else
                {
                    c = a;
                    a = b;
                    b = c + a;
                    Console.WriteLine("{0}", a);
                }
                count += 1;
                i = b;
            }
            Console.WriteLine("_________________________________ \n Tienes {0} numeros antes del {1}", count, top);
            Console.ReadKey();
        }
    }
}
