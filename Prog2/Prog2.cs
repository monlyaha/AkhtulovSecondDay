using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2
{
    internal class Prog2
    {
        /// <summary>
        /// Вычисление центра квадрата и его отрисовка
        /// </summary>
        /// <param name="length">Длина стороны квадрата</param>
        /// <returns>Квадрат с отверстием в центре в виде строки</returns>
        static string getOrder(double length)
        {
            string result = "";
            if (length == 1)
            {
                result += "*";
            }
            else
            {
                if (length % 2 == 0)
                {
                    Console.WriteLine("Для получения отверстия сторона квадрата должна быть нечетной длины!");
                }
                else
                {
                    double middlePoint = Convert.ToInt32((length / 2) - 0.5);

                    for (int i = 0; i < length; i++)
                    {
                        for (int j = 0; j <= length; j++)
                        {
                            if (i != middlePoint)
                            {
                                if (j != length)
                                {
                                    result += "* ";
                                }
                                else
                                {
                                    result += "\n";
                                }
                            }
                            else
                            {
                                if (j != length)
                                {
                                    if (j != middlePoint)
                                    {
                                        result += "* ";
                                    }
                                    else
                                        result += "  ";
                                }
                                else
                                {
                                    result += "\n";
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Главная функция, запрашивает длину квадрата и выводит готовый результат
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string result;
            Console.Write("Введите длину стороны квадрата: ");

            try
            {
                double length = Convert.ToInt32(Console.ReadLine());

                if (length < 0)
                {
                    Console.WriteLine("Число должно превышать 0!");
                }
                else
                {
                    result = getOrder(length);
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
