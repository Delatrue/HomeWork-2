using System;

namespace OOP5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RationalNum number = new RationalNum(10, 2);
            RationalNum number2 = new RationalNum(2, 10);

            RationalNum number3 = number / number2;
            Console.WriteLine(number3);

            number3 = number * number2;
            Console.WriteLine(number3);

            number3 = number + number2;
            Console.WriteLine(number3);

            number3 = number - number2;
            Console.WriteLine(number3);

            number3 = number--;
            Console.WriteLine(number3);

            number3 = number++;
            Console.WriteLine(number3);

            Console.WriteLine(number == number2);
            Console.WriteLine(number < number2);
            Console.WriteLine(number > number2);
            Console.WriteLine(number.Equals(number2));
        }
    }
}
