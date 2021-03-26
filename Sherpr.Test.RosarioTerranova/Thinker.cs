using System;
using System.Collections.Generic;
using System.Text;

namespace Sherpr.Test.RosarioTerranova
{
    class Thinker
    {
        private ICalculator calc;

        public Thinker()
        {
            calc = new Calculator();
        }

        public int MagicNumbers(int a, int b, int c)
        {
            int c1 = calc.Add(a, calc.Add(b, c));
            Console.WriteLine($"c1: {c1}");

            int c2 = calc.Subtract(a, calc.Subtract(b, c));
            Console.WriteLine($"c2: {c2}");

            int c3 = calc.Multiply(a, calc.Multiply(b, c));
            Console.WriteLine($"c3: {c3}");

            return c3;
        }
    }
}
