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

            int a = amount, billete = 0, btotal = 0;


            foreach (var num in bList)
            {
                //if (num >= a)
                //{
                //billete = num;                    
                //for (int i = 0; i < a; i++)
                //{
                //    btotal += 1;
                //}

                //Console.WriteLine(billete + " x " + btotal + " = " + billete * btotal);
                //foreach (var item in collection)
                //{

                //}
                if (a >= num)
                {
                    int i;
                    for (i = 0; num <= a; i++)
                    {
                        btotal = btotal + 1;
                        a = a - num;
                    }
                    
                    Console.WriteLine(num + " x " + btotal);
                } else
                {
                    //continue;
                }
                    

                

                    //return;
                //}

                //Console.WriteLine(num);
            }



            Console.ReadLine();
        }
    }
}
