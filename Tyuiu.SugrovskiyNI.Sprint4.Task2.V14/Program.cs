using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SugrovskiyNI.Sprint4.Task2.V14.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint4.Task2.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Сугровский Н. И. | ИИПб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Одномерные массивы (статический ввод)                                        *");
            Console.WriteLine("* Задание #2                                                                   *");
            Console.WriteLine("* Вариант #14                                                                  *");
            Console.WriteLine("* Выполнил: Сугровский Никита Игоревич | ИИПб-23-1                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный случайными в *");
            Console.WriteLine("* диапазоне от 1 до 8 подсчитать произведение нечетных элементов массива       *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            int len;
            Console.Write("Введите колличество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] sumArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                sumArray[i] = random.Next(1, 9);
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine(sumArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("Сумму нечетных элементов массива: ");

            int res = ds.Calculate(sumArray);


            Console.Write(res);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
