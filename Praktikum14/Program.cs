using System;
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
            Console.SetCursorPosition(4, 2);
            Console.Write("1");
            Console.SetCursorPosition(9, 2);
            Console.Write("4");
            Console.SetCursorPosition(14, 2);
            Console.Write("6");
            Console.SetCursorPosition(19, 2);
            Console.Write("8");
            Console.SetCursorPosition(24, 2);
            Console.Write("9");
            Console.SetCursorPosition(29, 2);
            Console.Write("10");
            Console.SetCursorPosition(34, 2);
            Console.Write("12");
        }
        public static void prime()
        {
            Console.SetCursorPosition(4, 2);
            Console.Write("2");
            Console.SetCursorPosition(9, 2);
            Console.Write("3");
            Console.SetCursorPosition(14, 2);
            Console.Write("5");
            Console.SetCursorPosition(19, 2);
            Console.Write("7");
            Console.SetCursorPosition(24, 2);
            Console.Write("11");
            Console.SetCursorPosition(29, 2);
            Console.Write("13");
            Console.SetCursorPosition(34, 2);
            Console.Write("17");
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
                {
                    bil = bil + 1;
                }
                else
                {
                    bil = bil;
                }
            }
            if (bil > 2 || bil == 1)
            {
                notprime();
            }
            else
            {
                prime();
            }
            Console.ReadKey();
        }
    }
}
