﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SugrovskiyNI.Sprint4.Task2.V14.Lib
{
    public class DataService : ISprint4Task2V14
    {
        public int Calculate(int[] array)
        {
            int sumArray = 1;

            // Вычисляем произведение нечетных элементов
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sumArray *= array[i];
                }
            }
            return sumArray;
        }
    }
}
