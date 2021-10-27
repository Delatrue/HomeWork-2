using System;

namespace Part2_Lesson_1_3_cycle
{
    class Program
    {
        public class TestNum
        {
            public int InputNum { get; set; }
            public int Expected { get; set; }
        }
        // Реализуйте функцию вычисления числа Фибоначчи
        // Цикл:
        static long GetNumFibo(long n)
        {              
            if(n == 0 || n == 1)
            {
                return n;                
            }
            if(n == 2)
            {
                return n - 1;
            }
            long num1 = 0;
            long num2 = 1;
            long num3 = num1 + num2;
            int i = 3;
            do
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
                i++;
            }
            while (i <= n);
            return num3;
        }
        static void Main(string[] args)
        {
            var testCase = new TestNum[4];
            testCase[0] = new TestNum()
            {
                InputNum = 0,
                Expected = 0
            };
            testCase[1] = new TestNum()
            {
                InputNum = 5,
                Expected = 5
            };
            testCase[2] = new TestNum()
            {
                InputNum = 13,
                Expected = 233
            };
            testCase[3] = new TestNum()
            {
                InputNum = 20,
                Expected = 6765
            };
            foreach (var test in testCase)
            {
                var result = GetNumFibo(test.InputNum);
                Console.WriteLine($"На вход: {test.InputNum}, получаем: {result}, ожидаем: {test.Expected}");
            }
        }
    }
}
