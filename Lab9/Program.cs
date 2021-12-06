using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Смоделируйте работу простого калькулятора. 
           * Программа должна запрашивать 2 числа, а затем – код операции 
           * (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное). 
           * После этого на консоль выводится ответ. 
           * Используйте обработку исключений для защиты от ввода некорректных данных.*/

            //Вариант калькулятора номер 1

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

            //Логический выбор операции
            switch (action)
            {
                case "+":
                    Console.Write("Сумма чисел: ");
                    Console.WriteLine(first + second);

                    break;
                case "-":
                    Console.Write("Разница между числами: ");
                    Console.WriteLine(first - second);

                    break;
                case "*":
                    Console.Write("Произведение чисел: ");
                    Console.WriteLine(first * second);

                    break;
                case "/":
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

                    break;
                default:
                    Console.WriteLine("Ошибка! Неизвестное действие");
                    break;
            }


            Console.ReadKey();
        }
    }
}
