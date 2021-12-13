﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum14
{
    class Program
    {
        public static void notprime()
        {
            Console.WriteLine("1\t4\t6\t8");
            Console.WriteLine("9\t10\t12\t14");
            Console.WriteLine("15\t16\t18\t20");
            Console.WriteLine("21\t22\t24\t25");
        }
        public static void isprime()
        {
            Console.WriteLine("2\t3\t5");
            Console.WriteLine("7\t11\t13");
            Console.WriteLine("17\t19\t23");
            Console.WriteLine("29\t31\t37");
        }
        static void Main(string[] args)
        {
            Console.Write("Input : ");
            int N = Convert.ToInt32(Console.ReadLine());
            string hasil;
            int bil = 0;
            Console.WriteLine("Output : ");
            for (int i = 1; i <= N; i++)
            {
                int angka = N % i;
                if (angka == 0)
                    bil = bil + 1;
                else bil = bil;
            }
            if (bil > 2 || N == 1)
            {
                notprime();
            }
            else
            {
                isprime();
            }
            Console.ReadKey();
        }
    }
}
