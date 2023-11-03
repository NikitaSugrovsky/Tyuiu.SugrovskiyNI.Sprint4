using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SugrovskiyNI.Sprint4.Task3.V30.Lib
{
    public class DataService : ISprint4Task3V30
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int maxElement = int.MinValue;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] > maxElement)
                    {
                        maxElement = array[i, j];
                    }
                }
            }
            return maxElement;
        }
    }
}
