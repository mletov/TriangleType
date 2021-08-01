using System;

namespace TriangleType
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sides = new int[] { 5, 6, 7 };
            var trType = TriangleTypeDetector.TriangleTypeDetector.GetTriangleType(sides);
            var trTypeRus = TriangleTypeDetector.TriangleTypeDetector.GetDescription(trType);

            Console.WriteLine($"Тип треугольника: {trTypeRus}");
            Console.ReadLine();
        }
    }
}
