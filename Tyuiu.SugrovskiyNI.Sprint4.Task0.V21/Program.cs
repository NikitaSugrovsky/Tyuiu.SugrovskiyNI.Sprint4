using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SugrovskiyNI.Sprint4.Task0.V21.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint4.Task0.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Сугровский Н. И. | ИИПб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Одномерные массивы (статический ввод)                                        *");
            Console.WriteLine("* Задание #0                                                                   *");
            Console.WriteLine("* Вариант #21                                                                  *");
            Console.WriteLine("* Выполнил: Сугровский Никита Игоревич | ИИПб-23-1                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный статическими *");
            Console.WriteLine("* значениями в диапазоне от 0 до 9 подсчитать сумму четных элементов массива. * ");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            int[] sumArray = { 8, 2, 4, 3, 8, 5, 6, 7, 9, 8 };

            Console.WriteLine("Исходный массив");
            for (int i = 0; i <= sumArray.Length - 1; i++)
            {
                Console.WriteLine(sumArray[i]);
            }


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("Сумму четных элементов массива: ");

            int res = ds.GetSumEvenArrEl(sumArray);

            
            Console.Write(res);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
