using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Calculator
    {
        public double Add(double value1, double value2)
        {
            return value1 + value2;
        }
        public double Subtract(double value1, double value2)
        {
            return value1 - value2;
        }
        public double Multiple(double value1, double value2)
        {
            return value1 * value2;
        }
        public double Divide(double value1, double value2)
        {
            return value1 / value2;
        }
        public double Remainder(double value1, double value2)
        {
            return value1 % value2;
        }
        public double Power(double value1, double value2)
        {
            return Math.Pow(value1, value2);
        }
        public double Max(double value1, double value2)
        {
            return Math.Max(value1, value2);
        }
    }
}
