using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            double a = Double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите оператор(+, -, /, *)");
            char b = char.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            double c = Double.Parse(Console.ReadLine());

            double result = 0;
            bool valid = true;

            switch (b)
            {
                case '+':
                    result = a + c; break;
                case '-':
                    result = a - c; break;
                case '*':
                    result = a * c; break;
                case '/':
                    result = a / c; break;
                default:
                    Console.WriteLine("Недопустимый опреатор!");
                    valid = false;
                    break;
            }
            if (valid)
            {
                Console.WriteLine($"Результат: {result}");
            }
            Console.ReadKey();
        }
    }
}
