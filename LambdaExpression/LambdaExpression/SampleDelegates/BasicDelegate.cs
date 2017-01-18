using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression.SampleDelegates
{
    public class BasicDelegate
    {
        private delegate int CalculationDelegate(int x, int y);
        private int Multiply(int x, int y)
        {
            return x * y;
        }
        private int Divide(int dividend, int divisor)
        {
            return dividend / divisor;
        }

        public void TestDelegate()
        {
            CalculationDelegate calculation = new CalculationDelegate(Multiply);
            Console.WriteLine(calculation(100, 2));
            calculation = new CalculationDelegate(Divide);
            Console.WriteLine(calculation(100, 2));
        }

        public void TestAnonymousFunction()
        {
            CalculationDelegate calculation;

            calculation = new CalculationDelegate(delegate (int x, int y) { return Math.Max(x, y); });
            Console.WriteLine(calculation(100, 200));

            Func<int, int, int> func = delegate (int x, int y) { return Math.Min(x, y); };
            calculation = new CalculationDelegate(func);
            Console.WriteLine(calculation(100, 200));
        }
    }
}
