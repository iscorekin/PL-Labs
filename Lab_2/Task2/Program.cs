using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static int[,] _InputMatrix(string liter)
        {
            int[,] matrix = new int[2, 2];
            Console.WriteLine("Введите матрицу {0}:", liter);

            matrix[0, 0] = int.Parse(Console.ReadLine());
            matrix[1, 0] = int.Parse(Console.ReadLine());
            matrix[0, 1] = int.Parse(Console.ReadLine());
            matrix[1, 1] = int.Parse(Console.ReadLine());

            Console.WriteLine($"Матрица {liter}:\n{matrix[0, 0]}  {matrix[1, 0]}\n{matrix[0, 1]}  {matrix[1, 1]}");
            Console.WriteLine("---------------------------");
            return matrix;
        }

        static int[,] _Multiply(int[,] matrix, int a)
        {
            matrix[0, 0] *= a;
            matrix[1, 0] *= a;
            matrix[0, 1] *= a;
            matrix[1, 1] *= a;

            return matrix;
        }

        static int[,] _Multiply(int[,] matrixA, int[,] matrixB)
        {
            int[,] matrix = new int[2, 2];

            matrix[0, 0] = matrixA[0, 0] * matrixB[0, 0] + matrixA[1, 0] * matrixB[0, 1];
            matrix[0, 1] = matrixA[0, 0] * matrixB[1, 0] + matrixA[1, 0] * matrixB[1, 1];
            matrix[1, 0] = matrixA[0, 1] * matrixB[0, 0] + matrixA[1, 1] * matrixB[0, 1];
            matrix[1, 1] = matrixA[0, 1] * matrixB[1, 0] + matrixA[1, 1] * matrixB[1, 1];

            return matrix;
        }

        static int[,] _Subtraction(int[,] matrixA, int[,] matrixB)
        {
            matrixA[0, 0] -= matrixB[0, 0];
            matrixA[1, 0] -= matrixB[1, 0];
            matrixA[0, 1] -= matrixB[0, 1];
            matrixA[1, 1] -= matrixB[1, 1];

            return matrixA;
        }

        static int[,] _Transpose(int[,] matrix)
        {
            int buffer;

            for(int i = 0; i < 2; ++i)
            {
                for (int j = 0; j < 2; ++j)
                {
                    buffer = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = buffer;
                }
            }

            return matrix;
        }

        static void Main(string[] args)
        {
            int[,] matrixA = new int[2, 2];
            int[,] matrixB = new int[2, 2];
            int[,] matrixC = new int[2, 2];

            matrixA = _InputMatrix("A");
            matrixB = _InputMatrix("B");
            matrixC = _InputMatrix("C");

            matrixA = _Multiply(matrixA, 5);
            matrixB = _Multiply(_Multiply(_Transpose(matrixB), 4), matrixC);

            matrixA = _Subtraction(matrixA, matrixB);

            Console.WriteLine($"Ответ:\n{matrixA[0, 0]}  {matrixA[1, 0]}\n{matrixA[0, 1]}  {matrixA[1, 1]}");

            Console.ReadKey();
        }
    }
}
