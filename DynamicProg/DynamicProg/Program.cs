using System;

namespace DynamicProg
{
    internal class Program
    {
        const int M = 10;
        const int N = 12;

        static void Print(int m, int n, int[,] area)
        {
            int i, j;
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write(area[i, j] + "  ");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] Area = new int[M, N];
            int i, j;
            for (j = 0; j < N; j++)
                Area[0, j] = 1; // Первая строка заполнена единицами
            for (i = 1; i < M; i++)
            {
                Area[i, 0] = 1; // Первый столбец заполнен единицами
                for (j = 1; j < N; j++)
                    Area[i, j] = Area[i, j - 1] + Area[i - 1, j];
            }

            Print(M, N, Area);
            Console.WriteLine($"Количсетво путей из клетки 0х0 в клетку {M}x{N} = "+ Area[M - 1, N - 1]);
        }
        
    }
}
