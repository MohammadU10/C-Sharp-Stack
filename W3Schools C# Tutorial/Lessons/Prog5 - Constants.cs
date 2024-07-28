﻿namespace Prog5___Constants
{
    internal class Prog5
    {
        static void Main(string[] args)
        {
            // Note (1): If you don't want others (or yourself) to overwrite existing values, you can add the const keyword in front of the variable type
            // This will declare the variable as "constant", which means unchangeable and read-only, Example:
            const int myNum = 15;
            myNum = 20; // error

            // Note (2):
            /* The const keyword is useful when you want a variable to always store the same value, so that others (or yourself) won't mess up your code.
             * An example that is often referred to as a constant, is PI (3.14159...). */

            // Note (3): You cannot declare a constant variable without assigning the value. If you do, an error will occur: A const field requires a value to be provided.
        }
    }
}