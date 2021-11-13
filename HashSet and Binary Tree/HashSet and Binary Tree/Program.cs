using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace HashSet_and_Binary_Tree
{
    public class BenchmarkClass
    {
        [Benchmark]
        public void Searching()
        {
            Random random = new Random();
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string[] stringArr = new string[10000];
            StringBuilder result = new StringBuilder(10000);
            for (int i = 0; i < stringArr.Length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            string searchString = "NHTEITJFNK";
            int index = Array.IndexOf(stringArr, searchString);
        }
        [Benchmark]
        public void SearchingHashSet()
        {
            Random random = new Random();
            HashSet<string> myHash = new HashSet<string>();
            while (myHash.Count < 10000)
            {
                string value = default;
                for (int j = 0; j < random.Next(5, 10); j++)
                    value += ((char)random.Next('A', 'Z')).ToString();
                    myHash.Add(value);
            }
            if (myHash.Contains("NHTEITJFNK"))
            {
                bool result = true;
            }
            else
            {
                bool result = false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
}
