using System;

namespace Алгоритмы._Ур_2._Бинарный_поиск
{
    class Program
    {
        // Бинарный поиск
        // Ас. сложность = O(log(n))
        public static int BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0; // O(1)
            int max = inputArray.Length - 1; // O(1)
            while (min <= max) // O(log(n))
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1; // O(1)
        }
        // Тестовый класс
        public class TestCase
        {
            public int Input { get; set; }
            public int Expected { get; set; }
        }
        // Тестовый метод
        static void Test(TestCase testCase)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 10, 9, 8, 7, 6 }; // Заданный массив
            
            int temp; // Сортировка массива пузрьком
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }
            int result = BinarySearch(myArray, testCase.Input); // Входные данные для поиска
            if (result == testCase.Expected && result != -1)
            {
                Console.WriteLine($"Индекс числа {testCase.Input} [" + result + "]"); // Test Valid
            }
            else
            {
                Console.WriteLine($"Число {testCase.Input} не найдено"); // Test Invalid
            }
        }
        static void Main(string[] args)
        {
            var testCase1 = new TestCase()
            {
                Input = 3,
                Expected = 2
            };
            var testCase2 = new TestCase()
            {
                Input = 7,
                Expected = 6
            };
            var testCase3 = new TestCase()
            {
                Input = 5,
                Expected = 4
            };
            var testCase4 = new TestCase()
            {
                Input = -10,
                Expected = -1
            };
            var testCase5 = new TestCase()
            {
                Input = 11,
                Expected = -1
            };
            Test(testCase1);
            Test(testCase2);
            Test(testCase3);
            Test(testCase4);
            Test(testCase5);
        }
        
    }
}
