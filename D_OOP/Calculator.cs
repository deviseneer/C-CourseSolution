using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public class Calculator
    {  

        //optional params
        public static double CalcTriangleSquareOP(double a, double b, int alpha, bool isInRadians = false)
        {
            if (isInRadians)
            {
                return 0.5 * a * b * Math.Sin(alpha);
            }
            else
            {
                double rads = alpha * Math.PI / 100;
                return 0.5 * a * b * Math.Sin(rads);
            }
        }




        public static double Average3(params int[] numbers)
        {
            int sum = 0;

            foreach (int n in numbers)
            {
                sum += n;
            }
            return (double)sum / numbers.Length;
        }




        public bool TryDivide(double divisible, double divisor, out double result)
        {
            result = 0;
            if (divisor == 0)
            {
                return false;
            }
            result = divisible / divisor;
            return true;
        }




        public double Average(int[] numbers)
        {
            int sum = 0;

            foreach (int n in numbers)
            {
                sum += n;
            }
            return (double)sum / numbers.Length;
        }
        public double Average2(params int[] numbers)
        {
            int sum = 0;

            foreach (int n in numbers)
            {
                sum += n;
            }
            return (double)sum / numbers.Length;
        }








        public double CalcTriangleSquare(double a, double b, double c, bool v)
        {
            double p = (a + b + c) / 2;
            double square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return square;
        }
        public double CalcTriangleSquare(double b, double h)
        {
            return 0.5 * b * h;
        }
        
        public double CalcTriangleSquare(double a, double b, int alpha)
        {
            double rads = alpha * Math.PI / 100;
            return 0.5 * a * b * Math.Sin(rads);
        }
    }
}
