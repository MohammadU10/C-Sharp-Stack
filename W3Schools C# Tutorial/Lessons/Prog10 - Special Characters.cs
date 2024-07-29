namespace Prog10___Special_Characters
{
    internal class Prog10
    {
        static void Main(string[] args)
        {
            // Strings - Special Characters
            // 1) Because strings must be written within quotes, C# will misunderstand this string, and generate an error:
            // string txt = "We are the so-called "Vikings" from the north.";
            // * The solution to avoid this problem, is to use the `backslash escape character`.
            /* The backslash (\) escape character turns special characters into string characters:
            ---------------------------------------------------------------
                [Escape character]        [Result]      [Description]
                       \'	                 '          Single quote
                       \"	                 "          Double quote
                       \\	                 \          Backslash
            ---------------------------------------------------------------
            */

            // The sequence \"  inserts a double quote in a string:
            string txt = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(txt);
            // The sequence \\  inserts a single backslash in a string:
            string txt2 = "The character \\ is called backslash.\n";
            Console.WriteLine(txt2);


            /* 2) Other useful escape characters in C# are:
            -----------------------------------------------
                [Code]        [Result]
                  \n	         '
                  \t	         "
                  \b	         \
            -----------------------------------------------
            */
            // a) Example for `\n`:
            string txt3 = "Welcome,\nUser.\n";
            Console.WriteLine(txt3);

            // b) Example for `\t`:
            string txt4 = "Welcome,\tUser.\n";
            Console.WriteLine(txt4);

            // c) Example for `\b`:
            string txt5 = "Hel\blo User.\n";
            Console.WriteLine(txt5);
        }
    }
}
