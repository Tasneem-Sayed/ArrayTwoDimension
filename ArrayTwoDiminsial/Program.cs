using System;

namespace ArrayTwoDiminsial
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] matrix = new int[3, 3];
            matrix[0, 0] = 0;
            matrix[0, 1] = 1;
            matrix[0, 2] = 2;
            matrix[1, 0] = 3;
            matrix[1, 1] = 4;
            matrix[1, 2] = 5;
            matrix[2, 0] = 6;
            matrix[2, 1] = 7;
            matrix[2, 2] = 8;

            for (int i = 0; i < matrix.GetLength(0) * matrix.GetLength(1); i++)
            {
                int row = i / matrix.GetLength(1);
                int column = i % matrix.GetLength(1);

                matrix[row, column] = i;
                Console.WriteLine(matrix[row, column].ToString());
            }

           
        }
    }
}
