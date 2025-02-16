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
            bool continueCalc = true; // Основной цикл работы калькулятора

            while (continueCalc)
            {
                Console.WriteLine("Выбор режима калькулятора:");
                Console.WriteLine("1 - Обычные операции(+,-,/,*)");
                Console.WriteLine("2 - Операции с корнями и степенями");
                int mode = Int32.Parse(Console.ReadLine());

                double result = 0; // Хранение результата вычислений
                bool valid = true; // Проверка корректности операции

                if (mode == 1)
                {
                    bool continueBasic = true; // Цикл для выполнения нескольких операций
                    while (continueBasic)
                    {
                        Console.WriteLine("Введите первое число");
                        double a = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Выберите оператор(+, -, /, *, 0 - назад)");
                        char b = char.Parse(Console.ReadLine());
                        if (b == '0') // Проверка на возврат в меню 
                        {
                            continueBasic = false;
                            Console.WriteLine("Для возврата к выбору режима, нажмите Enter...");
                            continue;
                        }

                        Console.WriteLine("Введите второе число");
                        double c = Double.Parse(Console.ReadLine());

                        switch (b)
                        {
                            case '+':
                                result = a + c; break;
                            case '-':
                                result = a - c; break;
                            case '*':
                                result = a * c; break;
                            case '/':
                                if (c != 0)
                                    result = a / c;
                                else
                                {
                                    Console.WriteLine("Ошибка: деление на ноль!");
                                    valid = false;
                                }
                                break;
                            default:
                                Console.WriteLine("Недопустимый оператор!");
                                valid = false;
                                break;
                        }

                        // Выводим результат, если операция корректна
                        if (valid)
                        {
                            Console.WriteLine($"Результат: {result}");
                        }
                    }
                }
                else if (mode == 2)
                {
                    bool continueAdvanced = true; // Цикл для выполнения операций с корнями и степенями
                    while (continueAdvanced)
                    {
                        Console.WriteLine("Выберите операцию (s - Корень, ^ - Степень, 0 - назад)");
                        char b = Char.Parse(Console.ReadLine());

                        if (b == '0') // Проверка на возврат в меню 
                        {
                            continueAdvanced = false;
                            Console.WriteLine("Для возврата к выбору режима, нажмите Enter...");
                            continue;
                        }

                        Console.WriteLine("Укажите число");
                        double a = Double.Parse(Console.ReadLine());

                        if (b == 's') // Выбрано извлечение корня
                        {
                            if (a >= 0)
                            {
                                result = Math.Sqrt(a);
                                Console.WriteLine($"Результат: {result}");
                            }
                            else
                            {
                                Console.WriteLine("Ошибка: нельзя извлекать корень из отрицательного числа!");
                            }
                        }
                        else if (b == '^') // Вырано возведение в степень
                        {
                            Console.WriteLine("Укажите степень числа");
                            double exp = Double.Parse(Console.ReadLine());
                            result = Math.Pow(a, exp);
                            Console.WriteLine($"Результат: {result}");
                        }
                        else
                        {
                            valid = false;
                            Console.WriteLine("Недопустимая операция!");
                        }
                    }
                }
                else if (mode != 1 && mode != 2) // Проверка на верный выбор режима
                {
                    Console.WriteLine("Ошибка: выберите корректный режим!");
                }
                Console.ReadKey();
            }
        }
    }
}
