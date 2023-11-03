using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SugrovskiyNI.Sprint4.Task3.V30.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint4.Task3.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas2 = new int[5, 5] { { 2, 4, 3, 5, 1, },
                                        { 6, 6, 1, 2, 6, },
                                        { 3, 3, 2, 1, 5, },
                                        { 6, 4, 1, 3, 3, },
                                        { 5, 1, 1, 6, 4, } };

            int rows = mas2.GetUpperBound(0) + 1;
            int columns = mas2.Length / rows;

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Сугровский Н. И. | ИИПб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Одномерные массивы (статический ввод)                                        *");
            Console.WriteLine("* Задание #3                                                                   *");
            Console.WriteLine("* Вариант #30                                                                  *");
            Console.WriteLine("* Выполнил: Сугровский Никита Игоревич | ИИПб-23-1                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("*Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими *");
            Console.WriteLine("* Найдите максимальный элемент в третьей строке массива.                       *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Массив: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas2[i, j]} \t");
                }

                Console.WriteLine();
            }


                Console.WriteLine("******************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
                Console.WriteLine("******************************************************************************");
                Console.WriteLine("Сумму нечетных элементов массива: ");

                int res = ds.Calculate(mas2);

                Console.WriteLine("Максимальный элемент в третьей строке массива = " + res);
                Console.ReadKey();
            }
        }
    }

