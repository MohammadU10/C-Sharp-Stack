namespace Prog8___C__Math_class
{
    internal class Prog8
    {
        static void Main(string[] args)
        {
            // The C# Math class has many methods that allows you to perform mathematical tasks on 


            // 1) Maximum: The Math.Max(x,y) method can be used to find the highest value of x and y:
            Console.WriteLine($"The Max Value of (150, 200) is: {Math.Max(150, 200)}");

            // 2) Minimum: The Math.Min(x,y) method can be used to find the lowest value of of x and y:
            Console.WriteLine($"The Min Value (234, 123) is: {Math.Min(234, 123)}\n");

            // 3) Square Root: The Math.Sqrt(x) method returns the square root of x:
            Console.WriteLine($"The Square Root of 121 is: {Math.Sqrt(121)}\n");

            // 4) Absolute Value: The Math.Abs(x) method returns the absolute (positive) value of x:
            Console.WriteLine($"The Absolute Value of -4.7 is: {Math.Abs(-4.7)}\n");

            // 5) Round: Math.Round() rounds a number to the nearest whole number:
            Console.WriteLine($"The Round of 4.56 is: {Math.Round(4.56)}\n");
        }
    }
}