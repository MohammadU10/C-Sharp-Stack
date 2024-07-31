using System;

namespace MyApplication
{
  class Prog15
  {
    
        // ** C# Method Overloading **
        // 1) With "method overloading", multiple methods can have the same name with different parameters:
        /* Example (1):
        int MyMethod(int x)
        float MyMethod(float x)
        double MyMethod(double x, double y)
        */


        // 2) Consider the following example, which have two methods that add numbers of different type:
        /* Example (2):
        static int PlusMethodInt(int x, int y)
        {
        	return x + y;
        }

        static double PlusMethodDouble(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int myNum1 = PlusMethodInt(8, 5);
            double myNum2 = PlusMethodDouble(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }
        */
        
        // * Instead of defining two methods that should do the same thing, it is better to overload one.
        // In the example below, we overload the `PlusMethod` method to work for both `int` and `double`:
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }
  }
}