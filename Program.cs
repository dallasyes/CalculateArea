using System;

namespace CalculateArea
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of circle: ");
            double radius = double.Parse(Console.ReadLine());
            double circleArea = FindCircleArea(radius);
            Console.WriteLine($"The area of the circle is: {circleArea}");
        }
        static double FindCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        

    }
}