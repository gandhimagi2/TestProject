using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Calculate
    {
        public double Add(double Value1, double Value2)
        {
            return Value1 + Value2;
        }
        public double Subtract(double Value1, double Value2)
        {
            return Value1 - Value2;
        }
        public double Multiply(double Value1, double Value2)
        {
            return Value1 * Value2;
        }
        public double Divide(double Value1, double Value2)
        {
            return Value1 / Value2;
        }
        public string Percentage(int Value1, int Value2)
        {
            Value1 = Value1 * 100;
            return Divide(Value1, Value2) + "%";
        }
    }
}