using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_var2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вариант калькулятора номер 2 c if и циклом, чтобы не заходить каждый раз

            while (true)
            {
                //Чтобы небыло бесконечного полотна, очистка консоли
                Console.Clear();

                Console.WriteLine("Вас привествует калькулятор!");

                //Запросить 2 числа и действия над ними


                Console.Write("Введите первое число: ");
                double first = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите второе число: ");
                double second = Convert.ToInt32(Console.ReadLine());



                //Переменная для сохранения действий над числами
                string action;
                Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");

                //Считаем то, что введет пользователь
                action = Console.ReadLine();


                if (action == "+")
                {
                    Console.Write("Сумма чисел: ");
                    Console.WriteLine(first + second);
                }
                else if (action == "-")
                {
                    Console.Write("Разница между числами: ");
                    Console.WriteLine(first - second);
                }
                else if (action == "*")
                {
                    Console.Write("Произведение чисел: ");
                    Console.WriteLine(first * second);
                }
                else if (action == "/")
                {
                    try
                    {
                        Console.Write("Частное: ");
                        Console.WriteLine(first / second);
                    }
                    catch (DivideByZeroException ex) when (first == 0 && second == 0)
                    {
                        Console.WriteLine("Деление 0 на 0");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка!Непредусмотренное действие.");
                }
                Console.WriteLine();
                Console.WriteLine("Для создания нового решения нажмите Enter");
                Console.ReadKey();
            }
            

        }
    }
}
