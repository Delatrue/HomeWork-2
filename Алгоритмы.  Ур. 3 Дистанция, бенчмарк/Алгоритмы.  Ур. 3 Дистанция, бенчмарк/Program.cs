using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace Алгоритмы.__Ур._3_Дистанция__бенчмарк
{
    public class PointClass //Ссылочный тип
    {
        public int X;
        public int Y;
    }
    public class PointStruct //Значимый тип
    {
        public int X;
        public int Y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
    public class BenchmarkClass
    {
        // Distance #1
        public static float PointDistanceClass(PointClass pointOne, PointClass pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
        // Distance #2
        public static float PointDistanceFloat(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
        // Distance #3
        public static double PointDistanceDouble(PointStruct pointOne, PointStruct pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((float)((x * x) + (y * y)));
        }
        // Distance #4
        public static float PointDistanceNoSqrt(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return (x * x) + (y * y);
        }
        [Benchmark] // test #1
        public void DistanceTestClass()
        {
            var pointClassX = new PointClass() { X = 10 };
            var pointClassY = new PointClass() { Y = 15 };
            PointDistanceClass(pointClassX, pointClassY);
        }
        [Benchmark] // test #2
        public void DistanceTestStruct()
        {
            var pointStructX = new PointStruct() { X = 10 };
            var pointStructY = new PointStruct() { Y = 15 };
            PointDistanceFloat(pointStructX, pointStructY);
        }
        [Benchmark] // test #3
        public void DistanceTestDouble()
        {
            var pointStructX = new PointStruct() { X = 10 };
            var pointStructY = new PointStruct() { Y = 15 };
            PointDistanceDouble(pointStructX, pointStructY);
        }
        [Benchmark] // test #4
        public void DistanceTestNoSqrt()
        {
            var pointStructX = new PointStruct() { X = 10 };
            var pointStructY = new PointStruct() { Y = 15 };
            PointDistanceNoSqrt(pointStructX, pointStructY);
        }
    }
}
