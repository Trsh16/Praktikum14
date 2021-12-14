using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum14
{
    class Program
    {
        public static void notprime(int N)
        {
            int v = 0;
            int angka = 0;
            int ifprime = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    ifprime = 0;
                    while (ifprime == 0)
                    {
                        angka++;
                        v = 0;
                        for (int k = 1; k <= angka; k++)
                        {
                            int l = angka % k;
                            if (l == 0)
                            {
                                v++;
                            }
                        }
                        if (v == 2)
                            ifprime = 0;
                        else
                            ifprime = 1;
                    }
                    Console.Write($"{angka} ".PadLeft(7));
                }
                Console.WriteLine();
            }
        }
        public static void isprime(int N)
        {
            int v = 0;
            int angka = 0;
            int ifprime = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    ifprime = 0;
                    while (ifprime == 0)
                    {
                        angka++;
                        v = 0;
                        for (int k = 1; k <= angka; k++)
                        {
                            int l = angka % k;
                            if (l == 0)
                            {
                                v++;
                            }
                        }
                        if (v == 2)
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
            int N = Convert.ToInt32(Console.ReadLine());
            if (N < 2)
                Console.WriteLine("Inputan minimal adalah 2");    
            else
            {
                Console.WriteLine("Output : ");
                int v = 0;
                for (int i = 1; i <= N; i++)
                {
                    int Bil = N % i;
                    if (Bil == 0)
                    {
                        v++;
                    }
                }
                if (v == 2)
                {
                    isprime(N);
                }
                else
                {
                    notprime(N);
                }
            }
            Console.ReadKey();
        }
    }
}
