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

            Console.WriteLine("Please enter the radius of the circle:");
            double radius = double.Parse(Console.ReadLine());
            double area = CircleAreaMethod(radius);
            Console.WriteLine("The area of the circle is: " + area);
        }
        
        static double CircleAreaMethod(double radius)
        {
            return Math.PI * radius * radius;
        }
            
    }
}
