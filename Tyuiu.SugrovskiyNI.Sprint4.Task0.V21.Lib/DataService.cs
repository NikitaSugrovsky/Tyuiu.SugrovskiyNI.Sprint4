﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SugrovskiyNI.Sprint4.Task0.V21.Lib
{
    public class DataService : ISprint4Task0V21
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int sum = 0;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }

            return sum;

        }
    }
}
