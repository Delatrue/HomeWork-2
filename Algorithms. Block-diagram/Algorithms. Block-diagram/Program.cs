using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox
{
    class Program
    {
        public class TestNum // тестовый класс
        {
            public int InputNum { get; set; }
            public bool Expected { get; set; }
        }
        static bool SimpleNumber(int n) // реализация блок схемы
        {
            int d = 0;
            int i = 2;

            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                    i++;
                }
                else
                {
                    i++;
                }
            }
            if (d == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void TestCase(TestNum testNum) //тестовый метод
        {
            try
            {
                var result = SimpleNumber(testNum.InputNum); //число на вход

                if (testNum.InputNum < 2) //условие - число положительное, 0 и 1 не простые
                {
                    throw new ArgumentException("Test Failed! Число должно быть положительным и больше 1");
                }
                
                if (result == testNum.Expected)
                {
                    Console.WriteLine($"На входе - {testNum.InputNum} Ожидаем - {testNum.Expected} На выходе - {result} ");
                }
                else
                {
                    Console.WriteLine("Test Failed!");
                }
            }
            catch(Exception)
            {
                if(testNum.InputNum < 2)
                {
                    Console.WriteLine("Число должно быть положительным и больше 1!");
                }
            }
        }
        static void Main(string[] args)
        {
            var testCase1 = new TestNum() //тестовые данные
            {
                InputNum = 0,
                Expected = false
            };
            var testCase2 = new TestNum()
            {
                InputNum = 4,
                Expected = false
            };
            var testCase3 = new TestNum()
            {
                InputNum = 11,
                Expected = true
            };
            var testCase4 = new TestNum()
            {
                InputNum = 55,
                Expected = false
            };
            var testCase5 = new TestNum()
            {
                InputNum = 83,
                Expected = true
            };
            Console.WriteLine("true - простое; false - составное"); //вывод результатов на консоль
            TestCase(testCase1);
            TestCase(testCase2);
            TestCase(testCase3);
            TestCase(testCase4);
            TestCase(testCase5);
        }
    }
}
