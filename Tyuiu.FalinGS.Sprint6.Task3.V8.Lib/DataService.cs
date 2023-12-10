using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.FalinGS.Sprint6.Task3.V8.Lib
{
    public class DataService : ISprint6Task3V8
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int col = 0; col < columns; col++)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < rows - i - 1; j++)
                    {
                        if (j == 3 && matrix[j, col] % 2 == 0) // Проверяем, является ли строка 4 и значение четным
                        {
                            matrix[j, col] = 0; // Если да, заменяем значение на 0
                        }
                    }
                }
            }

            return matrix;
        }
    }
}
