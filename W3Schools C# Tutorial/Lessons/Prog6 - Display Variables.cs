using System.Runtime.Intrinsics.X86;

namespace Prog6___Display_Variables
{
    internal class Prog6
    {
        static void Main(string[] args)
        {
            // 1) The WriteLine() method is often used to display variable values to the console window.
            // To combine both text and a variable (concatenate), use the '+' character:
            string name = "John";
            Console.WriteLine("Hello " + name);

            // 2) You can also use the + character to add a variable to another variable (concatenates for strings):
            string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            // 3) For numeric values, the + character works as a mathematical operator (notice that we use int (integer) variables here):
            int x = 5;
            int y = 6;
            Console.WriteLine(x + y); // Print the value of x + y
            /* From the example above, you can expect:
             * x stores the value 5
             * y stores the value 6
             * Then we use the WriteLine() method to display the value of x + y, which is 11.
             */
        }
    }
}