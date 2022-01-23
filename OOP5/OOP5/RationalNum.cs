using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    internal class RationalNum
    {
        private double _numerator;
        private double _denominator;

        public RationalNum(double x, double y)
        {
            _numerator = x;
            _denominator = y;
        }

        public double X
        {
            get { return _numerator; }
            set { _numerator = value; }
        }
        public double Y
        {
            get { return _denominator; }
            set { _denominator = value; }
        }
        // ToString()
        public override string ToString()
        {
            return "Дробь: " + _numerator + "/" + _denominator;
        }
        // Общий знаменатель
        public static void _CommonDenomenator(RationalNum num1, RationalNum num2)
        {
            if (num1.Y != num2.Y)
            {
                num1.X = num1.X * num2.Y;
                num2.X = num2.X * num1.Y;
                num1.Y = num1.Y * num2.Y;
                num2.Y = num1.Y;
            }
        }
        // Перегрузка  !=  ==  Equals  GetHashCode <> <= >=
        public static bool operator !=(RationalNum num1, RationalNum num2)
        {
            _CommonDenomenator(num1, num2);
            if (num1.X != num2.X)
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(RationalNum num1, RationalNum num2)
        {
            _CommonDenomenator(num1, num2);
            if (num1.X == num2.X)
            {
                return true;
            }
            return false;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            RationalNum other = (RationalNum)obj;
            return _numerator.Equals(other._numerator) && _denominator.Equals(other._denominator);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator <(RationalNum num1, RationalNum num2)
        {
            _CommonDenomenator(num1, num2);
            if (num1.X < num2.X)
            {
                return true;
            }
            return false;
        }
        public static bool operator >(RationalNum num1, RationalNum num2)
        {
            _CommonDenomenator(num1, num2);
            if (num1.X > num2.X)
            {
                return true;
            }
            return false;
        }
        public static bool operator <=(RationalNum num1, RationalNum num2)
        {
            _CommonDenomenator(num1, num2);
            if (num1.X <= num2.X)
            {
                return true;
            }
            return false;
        }
        public static bool operator >=(RationalNum num1, RationalNum num2)
        {
            _CommonDenomenator(num1, num2);
            if (num1.X >= num2.X)
            {
                return true;
            }
            return false;
        }
        public static RationalNum operator ++(RationalNum num1)
        {
            num1.X++;
            return num1;
        }
        public static RationalNum operator --(RationalNum num1)
        {
            num1.X--;
            return num1;
        }

        public static RationalNum operator +(RationalNum num1, RationalNum num2)
        {
            _CommonDenomenator(num1, num2);
            return new RationalNum(num1.X + num2.X, num1.Y);
        }
        public static RationalNum operator -(RationalNum num1, RationalNum num2)
        {
            _CommonDenomenator(num1, num2);
            return new RationalNum(num1.X - num2.X, num1.Y);
        }
        public static RationalNum operator *(RationalNum num1, RationalNum num2)
        {
            return new RationalNum(num1.X * num2.X, num1.Y * num2.Y);
        }
        public static RationalNum operator /(RationalNum num1, RationalNum num2)
        {
            return new RationalNum(num1.X * num2.Y, num1.Y * num2.X);
        }
        public static RationalNum operator %(RationalNum num1, RationalNum num2)
        {
            return new RationalNum(num1.X * num2.Y, num1.Y * num2.X);
        }
        public static explicit operator float(RationalNum num1)
        {
            return (float)num1;
        }
        public static explicit operator int(RationalNum num1)
        {
            return (int)num1;
        }

    }
}
