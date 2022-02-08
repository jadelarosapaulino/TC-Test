using System;

namespace DesgloseBilletes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calc();
        }

        static void calc()
        {
            int[] bList = new int[] { 2000, 1000, 500, 200, 100, 50, 25, 10, 5, 1 };

            var amount = int.Parse(Console.ReadLine());

            int a = amount, btotal = 0;


            foreach (var num in bList)
            {
                if (a >= num)
                {
                    for (int i = 0; num <= a; i++)
                    {
                        btotal = btotal + 1;
                        a = a - num;
                    }
                    Console.WriteLine(btotal + " x " +  num + " = " + btotal * num);
                }

                btotal = 0;
            }

            Console.ReadLine();
        }
    }
}
