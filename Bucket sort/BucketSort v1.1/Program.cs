using System;
using System.Collections.Generic;

namespace BucketSort_v1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BucketSorting bucketSorting = new BucketSorting();

            int[] array = {-3, 12, 56, 23, -8, 120, 8 };

            bucketSorting.BucketSort(ref array);

            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
            
        }        
    }
    public class BucketSorting
    {
        public void BucketSort(ref int[] array)
        {
            if (array.Length <= 1)
            {
                return;
            }

            int maxValue = array[0];
            int minValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }

                if (array[i] < minValue)
                {
                    minValue = array[i];
                }                    
            }

            List<int>[] bucket = new List<int>[maxValue - minValue + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }

            for (int i = 0; i < array.Length; i++)
            {
                bucket[array[i] - minValue].Add(array[i]);
            }

            int index = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        array[index] = bucket[i][j];
                        index++;
                    }
                }
            }
        }
    }

}
