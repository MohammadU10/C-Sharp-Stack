using System;

namespace Prog7___Identifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1) C# Identifiers:
             * All C# variables must be identified with unique names.
             * These unique names are called identifiers.
             * Identifiers can be short names (like x and y) or more descriptive names (age, sum, totalVolume).
             * Note: It is recommended to use descriptive names in order to create understandable and maintainable code:
             * Example: */
            // Good
            int minutesPerHour = 60;

            // OK, but not so easy to understand what m actually is
            int m = 60;

            /* 2) The general rules for naming variables are:
             * Names can contain letters, digits and the underscore character (_)
             * Names must begin with a letter or underscore
             * Names should start with a lowercase letter, and cannot contain whitespace
             * Names are case-sensitive ("myVar" and "myvar" are different variables)
             * Reserved words (like C# keywords, such as int or double) cannot be used as names. */

            // 3) Exercise: Create a variable named myNum and assign the value 50 to it:
            int myNum = 50;
            Console.WriteLine(myNum);
        }
    }
}