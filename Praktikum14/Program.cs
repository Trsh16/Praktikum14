using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum14
{
    class Program
    {
        public static void notprime(int bil)
        {
            int counter = 0;
            int angka = 0;
            int ifprime = 0;
            for (int i = 0; i < bil; i++)
            {
                for (int j = 0; j < bil; j++)
                {
                    ifprime = 0;
                    while (ifprime == 0)
                    {
                        angka++;
                        counter = 0;
                        for (int k = 1; k <= angka; k++)
                        {
                            if (angka % k == 0)
                            {
                                counter++;
                            }
                        }
                        if (counter == 2)
                            ifprime = 0;
                        else
                            ifprime = 1;
                    }
                    Console.Write($"{angka} ".PadLeft(7));
                }
                Console.WriteLine();
            }
        }
        public static void isprime(int bil)
        {
            int counter = 0;
            int angka = 0;
            int ifprime = 0;
            for (int i = 0; i < bil; i++)
            {
                for (int j = 0; j < bil; j++)
                {
                    ifprime = 0;
                    while (ifprime == 0)
                    {
                        angka++;
                        counter = 0;
                        for (int k = 1; k <= angka; k++)
                        {
                            if (angka % k == 0)
                            {
                                counter++;
                            }
                        }
                        if (counter == 2)
                            ifprime = 1;
                        else
                            ifprime = 0;
                    }
                    Console.Write($"{angka} ".PadLeft(7));
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Input : ");
            int bil = Convert.ToInt32(Console.ReadLine());
            if (bil < 2)
                Console.WriteLine("Inputan minimal adalah 2");    
            else
            {
                Console.WriteLine("Output : ");
                int counter = 0;
                for (int i = 1; i <= bil; i++)
                {
                    if (bil % i == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 2)
                {
                    isprime(bil);
                }
                else
                {
                    notprime(bil);
                }
            }
            Console.ReadKey();
        }
    }
}
