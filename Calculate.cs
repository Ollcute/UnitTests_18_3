using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest3
{
    public class Calculate
    {

        private double result = 0.0;

        public Calculate() { }
        public void Calc(double a, double b, double c, double x)
        {
            if (a < 0 && c != 0)
            {
                result = a * x * x + b + c;
                return;
            }
            if (a > 0 && c == 0)
            {
                result = -a / (x - c);
                return;
            }
            else
            {
                result = a * (x + c);
                return;
            }

            Console.WriteLine("Значение функции равно: {0}", result);
            //Console.ReadKey();

        }

        public double GetResult()
        {
            return result;
        }
    }
}
