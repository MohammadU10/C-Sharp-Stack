namespace Prog4___Variables
{
    internal class Prog4
    {
        static void Main(string[] args)
        {
            // Note (1): Declaring (Creating) Variables
            /* To create a variable, you must specify the type and assign it a value, So the Syntax will be like this:
            type variableName = value;
            Where type is a C# type (such as int or string), and variableName is the name of the variable (such as x or name). The equal sign is used to assign values to the variable. */


            // Example (1): Create a variable called name of type string and assign it the value "John":
            string name = "John";
            Console.WriteLine(name);

            // Example (2): Create a variable called myNum of type int and assign it the value 15:
            int myNum1 = 10;
            Console.WriteLine(myNum1);


            // Note (2): You can also declare a variable without assigning the value, and assign the value later:
            int myNum2;
            myNum2 = 20;
            Console.WriteLine(myNum2);

            // Note (3): If you assign a new value to an existing variable, it will overwrite the previous value:
            int myNum3 = 15;
            myNum3 = 30; // myNum is now 30
            Console.WriteLine(myNum3);


            // Note (4): Other Types
            // A demonstration of how to declare variables of other types:
            int myNum4 = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";
        }
    }
}