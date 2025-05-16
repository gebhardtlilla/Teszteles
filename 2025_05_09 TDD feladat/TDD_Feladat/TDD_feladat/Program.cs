using System;

namespace TDD_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = {
                "C C C",
                "C C C",
                "C C C"
            };
            Room room = new Room(3, input);
            LightCalculator calc = new LightCalculator(room, 2);
            calc.CalculateLight();
        }
    }
}
