using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        s static void Main(string[] args)
        {
            static int add(int x, int y)
            {
                return (x + y);
            }
            static int minus(int x, int y)
            {
                return (x - y);
            }
            static int umnoz(int x, int y)
            {
                return (x * y);
            }
            static int deli(int x, int y)
            {
                return (x / y);
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Введите 2 числа");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Выберите операцию: 1. сложение, 2 вычитание, 3 умножения, 4 деление");
                int op = Convert.ToInt32(Console.ReadLine());
                if (op == 1)
                {
                    Console.WriteLine(add(a, b));
                }
                else if (op == 2)
                {
                    Console.WriteLine(minus(a, b));
                }
                else if (op == 3)
                {
                    Console.WriteLine(umnoz(a, b));
                }
                else if (op == 4)
                {
                    Console.WriteLine(deli(a, b));
                }
            }
}
