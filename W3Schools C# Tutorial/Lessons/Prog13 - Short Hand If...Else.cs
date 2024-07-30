using System;

namespace MyApplication
{
  class Prog13
  {
    static void Main(string[] args)
    {
        // ** C# Short Hand If...Else (Ternary Operator) **
        /* There is also a short-hand if else, which is known as the "ternary operator" because it consists of three operands.
        It can be used to replace multiple lines of code with a single line. */
        // It is often used to replace simple if else statements:
        /* 1) Syntax:
        variable = (condition) ? expressionTrue :  expressionFalse;
        */


        // 2) Instead of writing:
        int time = 20;
        if (time < 18) 
        {
            Console.WriteLine("Good day.\n");
        } 
        else 
        {
            Console.WriteLine("Good evening.\n");
        }
        // You can simply write:
        int time2 = 20;
        string result = (time2 < 18) ? "Good day.\n" : "Good evening.\n";
        Console.WriteLine(result);


        // 3) Exercise: Print "Hello World" if x is greater than y.
        int x = 50;
        int y = 10;
        if(x > y) 
        {
            Console.WriteLine("Hello World");
        }
    }
  }
}