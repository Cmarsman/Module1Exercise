using System.Security.Principal;

namespace Module1Exercise

    class Program
    {
        static double baseLength; 
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //double radius = 5.0;
            //double area = CircleAreaMethod(radius);
            //Console.WriteLine("The area of the circle is: " + area);

            // Area of the Circle
            Console.WriteLine("Please enter the radius of the circle:");
            double radius = double.Parse(Console.ReadLine());
            double area = CircleAreaMethod(radius);
            Console.WriteLine("The area of the circle is: " + area);

            //Area of the Triangle
            Console.WriteLine("\nPlease enter the baseLength of triangle.");
            double baseLength = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the height of triangle.");
            double height = double.Parse(Console.ReadLine());
            double triangleArea = TriangleAreaMethod(baseLength, height);
            Console.WriteLine("The area of the triangle is: " + triangleArea);

            //Area of the Rectangle 
            Console.WriteLine("\nPlease enter the Length of rectangle.");
            double Length = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the width of rectangle.");
            double width = double.Parse(Console.ReadLine());
            double rectangleArea = RectangleAreaMethod(Length, width);
            Console.WriteLine("The area of the rectangle is: " + rectangleArea);

            //Area of the Square
            Console.WriteLine("\nPlease enter a side of the square.");
            double side = double.Parse(Console.ReadLine());
            double squareArea = SquareAreaMethod(side * side);
            Console.WriteLine("The area of the square is: " + squareArea);
        }
        
        static double CircleAreaMethod(double radius)
        {
            return Math.PI * radius * radius;
        }

        static double TriangleAreaMethod(double baseLength, double height)
        {
            return (baseLength * height) / 2;
        }

        static double RectangleAreaMethod(double length, double width)
        {
            return (baseLength * width) / 2;
        }

        static double SquareAreaMethod(double side)
            {
            return (side * side);
            }
        }
    }

