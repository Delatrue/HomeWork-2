using System;
using System.Collections.Generic;

namespace Bucket_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 99, 95, 90, 85, 80, 75, 70, 65, 60, 55, 50, 45, 40, 35, 30, 25, 20, 15, 10, 5, 1 };
            List<int> sorted = BucketSort.BucketSort1(x);
            foreach (int i in sorted)
                Console.WriteLine(i);
        }
        public static class BucketSort
        {
            public static List<int> BucketSort1(params int[] x)
            {
                List<int> result = new List<int>();

                //Определяем кол-во контейнеров - будет 10 по 10 элементов, тк массив от 1 до 99
                int numOfBuckets = 10;

                //Создаем контейнеры
                List<int>[] buckets = new List<int>[numOfBuckets];
                for (int i = 0; i < numOfBuckets; i++)
                    buckets[i] = new List<int>();

                //Перебераем массив и кладем каждый элемент в контейнер
                for (int i = 0; i < x.Length; i++)
                {
                    int bucketChoice = (x[i] / numOfBuckets);
                    buckets[bucketChoice].Add(x[i]);
                }

                //Сортруем каждый контейнер и добавляем результат в список
                for (int i = 0; i < numOfBuckets; i++)
                {
                    int[] temp = BubbleSortList(buckets[i]);
                    result.AddRange(temp);
                }
                return result;
            }
            public static int[] BubbleSortList(List<int> input)
            {
                for (int i = 0; i < input.Count; i++)
                {
                    for (int j = 0; j < input.Count; j++)
                    {
                        if (input[i] < input[j])
                        {
                            int temp = input[i];
                            input[i] = input[j];
                            input[j] = temp;
                        }
                    }
                }
                return input.ToArray();
            }
        }
    }
}
