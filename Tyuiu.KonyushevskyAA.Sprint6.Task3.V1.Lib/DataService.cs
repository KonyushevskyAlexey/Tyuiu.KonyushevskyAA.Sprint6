using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KonyushevskyAA.Sprint6.Task3.V1.Lib
{
    public class DataService : ISprint6Task3V1
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[] oneColumn = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                oneColumn[i] = matrix[i, 0];
            }
            Array.Sort(oneColumn);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, 0] = oneColumn[i];
            }
            return matrix;
        }
    }
}
