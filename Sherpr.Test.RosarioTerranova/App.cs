using System;

namespace Sherpr.Test.RosarioTerranova
{
    class App
    {
        static void Main(string[] args)
        {
            Thinker thinker = new Thinker();
            int result = thinker.MagicNumbers(2,3,4);
            Console.WriteLine($"Result: {result}");
        }
    }
}
