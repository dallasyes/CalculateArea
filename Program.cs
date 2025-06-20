using System;

namespace CalculateArea
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Circle Area
            Console.WriteLine("Enter the radius of circle: ");
            double radius = double.Parse(Console.ReadLine());
            double circleArea = FindCircleArea(radius);
            Console.WriteLine($"The area of the circle is: {circleArea}\n");
            
            // Triangle Area
            Console.WriteLine("Enter the length of the base of the triangle: ");
            double baseLength = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the triangle: ");
            double height = double.Parse(Console.ReadLine());
            double triangleArea = FindTriangleArea(baseLength, height);
            Console.WriteLine($"The area of the triangle is: {triangleArea}\n");
            
            //Rectangle Area
            Console.WriteLine("Enter the length of the rectangle:");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle:");
            double width = Convert.ToDouble(Console.ReadLine());
            double rectangleArea = FindRectangleArea(length, width);
            Console.WriteLine($"Area of the rectangle: {rectangleArea}\n");
            
            // Square Area
            Console.WriteLine("Enter the side length of the square:");
            double side = Convert.ToDouble(Console.ReadLine());
            double squareArea = FindSquareArea(length);
            Console.WriteLine($"Area of the square: {squareArea}\n");
        }
        static double FindCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        static double FindTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }
        static double FindRectangleArea(double length, double width)
        {
            return length * width;
        }
        static double FindSquareArea(double side)
        {
            return side * side;
        }
        
        

    }
}