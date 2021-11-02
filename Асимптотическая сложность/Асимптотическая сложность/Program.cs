using System;

namespace Асимптотическая_сложность
{
    class Program
    {
        //Посчитать сложность функции.
        //Итог: O(1+ (N * N * N) + 1) = O(2(N^3)) = O(N^3)
        static void Main(string[] args)
        {
            public static int StrangeSum(int[] inputArray)
            {
                int sum = 0; // O(1)

                for (int i = 0; i < inputArray.Length; i++) // O(N)
                {
                    for (int j = 0; j < inputArray.Length; j++) // O(N)
                    {
                        for (int k = 0; k < inputArray.Length; k++) //O(N)
                        {
                            int y = 0;

                            if (j != 0)
                            {
                                y = k / j;
                            }

                            sum += inputArray[i] + i + k + j + y;
                        }
                    }
                }

                return sum; //O(1)
            }


        }
    }
}
