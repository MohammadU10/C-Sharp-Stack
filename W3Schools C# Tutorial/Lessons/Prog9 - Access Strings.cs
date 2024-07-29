namespace Prog9___Access_Strings
{
    internal class Prog9
    {
        static void Main(string[] args)
        {
            // 1) You can access the characters in a string by referring to its index number inside square brackets [].
            // This example prints the first character in myString:
            string myString = "Ninja";
            Console.WriteLine(myString[0]);  // Outputs "N"
            // * Note: String indexes start with 0: [0] is the first character. [1] is the second character, etc.

            //This example prints the second character (1) in myString:
            string myString2 = "Ninja";
            Console.WriteLine(myString2[1]);  // Outputs "i"


            // 2) You can also find the index position of a specific character in a string, by using the IndexOf() method:
            string myString3 = "Thank You";
            Console.WriteLine(myString3.IndexOf("a"));  // Outputs "2"


            /* 3) Another useful method is Substring(), which extracts the characters from a string,
             * starting from the specified character position/index, and returns a new string.
             * This method is often used together with IndexOf() to get the specific character position: */

            // Full name
            string name = "Mohammad You";

            // Location of the letter D
            int charPos = name.IndexOf("Y");

            // Get last name
            string lastName = name.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName);
        }
    }
}