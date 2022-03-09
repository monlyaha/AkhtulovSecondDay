using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class Prog1
    {
        /// <summary>
        /// Получение готовой строки
        /// </summary>
        /// <param name="number">Максимальное значение для строки</param>
        /// <returns>Готовая строка</returns>
        static string getOrder(int number) 
        {
            string result = "";

            for (int i = 1; i <= number; i++)           
            {
                result = result + i + " ";
            }
            return result;
        }

        /// <summary>
        /// Запрос на ввод числа и вывод результата
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string result;
            Console.Write("Введите положительное число: ");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    Console.WriteLine("Число должно превышать 0!");
                }
                else
                {
                    result = getOrder(number);
                    Console.WriteLine(result);
                }
            }
            catch
            { 
                Console.WriteLine("Введено неверное значение!");
            }
            Console.ReadLine();
        }
        
    }
}
