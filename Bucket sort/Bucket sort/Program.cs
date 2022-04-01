using System;
using System.Collections.Generic;

namespace Bucket_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {95, 90, 85, 80, 75, 70 };
            List<int> sorted = BucketSort.BucketSorting(array);
            foreach (int i in sorted)
            {
                Console.WriteLine(i);
            }
        }
        public class BucketSort
        {
            public static List<int> BucketSorting(params int[] array)
            {
                List<int> result = new List<int>();

                //Определяем кол-во контейнеров - будет 10 по 10 элементов, тк массив от 1 до 99
                int numOfBuckets = array.Length;

                //Создаем контейнеры
                List<int>[] buckets = new List<int>[numOfBuckets];
                for (int i = 0; i < numOfBuckets; i++)
                    buckets[i] = new List<int>();

                //Перебераем массив и кладем каждый элемент в контейнер
                for (int i = 0; i < array.Length; i++)
                {
                    int bucketChoice = (array[i] % numOfBuckets);
                    buckets[bucketChoice].Add(array[i]);
                }

                //Сортруем каждый контейнер и добавляем результат в список
                for (int i = 0; i < numOfBuckets; i++)
                {
                    buckets[i].Sort();
                }
                return result;
            }
            
        }
    }
}
