using System;

namespace MyApplication
{
  class Prog12
  {
    static void Main(string[] args)
    {
    	// Use the `else if` statement to specify a new condition if the first condition is `False`.
        /* 1) Syntax:
        if (condition1)
		{
  			// block of code to be executed if condition1 is True
		} 
		else if (condition2) 
		{
  			// block of code to be executed if the condition1 is false and condition2 is True
		} 
		else
		{
  			// block of code to be executed if the condition1 is false and condition2 is False
		}
        */
        
        
        // 2) Example:
        int time = 22;
      	if (time < 10) 
      	{
        	Console.WriteLine("Good morning.");
      	} 
      	else if (time < 20) 
      	{
        	Console.WriteLine("Good day.");
      	} 
      	else 
      	{
        	Console.WriteLine("Good evening.");
      	}
        // Outputs "Good evening."
        /* Example explained
        * In the example above, time (22) is greater than 10, so the first condition is False.
        The next condition, in the else if statement, is also False,
        so we move on to the else condition since condition1 and condition2 is both False - and print to the screen "Good evening".
        
        * However, if the time was 14, our program would print "Good day."
        */
    }
  }
}