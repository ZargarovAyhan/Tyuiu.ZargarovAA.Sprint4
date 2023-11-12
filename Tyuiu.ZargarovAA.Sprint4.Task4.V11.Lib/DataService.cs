using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZargarovAA.Sprint4.Task4.V11.Lib
{
    public class DataService : ISprint4Task4V11
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int s = 0;
            for (int i = 0; i < rows; i++)

            {

                for (int j = 0; j < columns; j++)
                {

                    if (matrix[i, j] % 2 != 0)
                    {
                        s += matrix[i, j];
                    }
                    if ((matrix[i, j] < 5) || (matrix[i, j] > 8))
                    {
                        throw new ArgumentException($"Введён некорректный элемент массива. Значение не входит в диапозон. Введённое значение {matrix[i, j]}");
                    }
                }
            }
            return s;
        }

        int[,] ISprint4Task4V11.Calculate(int[,] matrix)
        {
            throw new NotImplementedException();
        }
    }
}
