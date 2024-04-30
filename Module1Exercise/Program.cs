namespace Module1Exercise
{
    internal class Program
    {
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
            //Area of the Square
        }
        
        static double CircleAreaMethod(double radius)
        {
            return Math.PI * radius * radius;
        }
            
        static double TriangleAreaMethod(double baseLength, double height)
        {
            return (baseLength * height) / 2;
        }
    }
}
