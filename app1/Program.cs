using System;
using System.Collections.Generic;
using System.Text;

namespace app1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.Write("Number : ");
                int number = int.Parse(Console.ReadLine());
                int mull = 1;

                for (int j = 1; j <= number; j++) mull *= j;

                Console.WriteLine("fc : {0}", mull);
            }

            Console.ReadKey();
        }
    }
}
