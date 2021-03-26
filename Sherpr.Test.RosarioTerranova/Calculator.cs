using System;
using System.Collections.Generic;
using System.Text;

namespace Sherpr.Test.RosarioTerranova
{
    class Calculator : ICalculator
    {
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        public int Subtract(int value1, int value2)
        {
            return value1 - value2;
        }

        public int Multiply(int value1, int value2)
        {
            int result = 0;
            for (int i = 0; i < value2; i++)
            {
                result = Add(result, value1);
            }
            return result;
        }
    }
}
