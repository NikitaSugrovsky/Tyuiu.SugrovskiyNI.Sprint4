using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SugrovskiyNI.Sprint4.Task5.V18.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint4.Task5.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнил: Сугровский Н. И. | ИИПб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Двумерные массивы. (генератор случайных чисел)                               *");
            Console.WriteLine("* Задание #5                                                                   *");
            Console.WriteLine("* Вариант #18                                                                  *");
            Console.WriteLine("* Выполнил: Сугровский Никита Игоревич | ИИПб-23-1                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,заполненный случайными   *");
            Console.WriteLine("* значениями в диапазоне от -6 до 7. Заменить отрицательные элементы на 0      *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] mas2 = new int[rows, columns];

            Console.WriteLine("******************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mas2[i, j] = rnd.Next(-1, 1);
                }
            }

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas2[i, j]} \t ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            int[,] res = ds.Calculate(mas2);

            Console.WriteLine("Заменили отрицательные элементы на 0 ");
            Console.ReadKey();
        }
    }
}
