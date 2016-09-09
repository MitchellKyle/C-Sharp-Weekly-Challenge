﻿using System;

namespace CodeLou.CSharp.Week2.Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1:
            // The Console class is in the System namespace in the .Net framework. Add a "using" statement
            // to the top of this file to import the System namespace so that the C# compiler knows where
            // to look for the Console class.

            // Task 2:
            // This application won't build because of a syntax error. Fix the code below to make it build.
            // Hint: In Visual Studio, you can build the project by selecting "Build Solution" from the
            //       build menu, or by pressing <Ctrl>+<Shift>+B.
            Console.WriteLine("Welcome to the Code Louisville C# week 2 code challenge!");
            Console.WriteLine("Press <Enter> to begin...");
            Console.ReadLine();

            Console.WriteLine("This is the launch application for the first human mission to Mars.");
            Console.Write("Enter the number of seconds you would like to count down from: ");

            // Task 3:
            // Capture the number of seconds that the user would like to count down before liftoff.
            // Hint: You should use another method of the Console class and store the output into a
            //       variable to use later.
            var stringOfSeconds = Console.ReadLine();

            // Task 4:
            // Write a condition to test whether the number that they entered is less than or equal to zero.
            // Call the IsLessThanOrEqualToZero() method below, passing the user's number as a parameter.
            // If the result is true, write "Please enter a positive number." to the console.
            // Hint: The input that you captured is currently a string type. You will have to "parse" it
            //       as a different type in order to pass it to the IsLessThanOrEqualToZero function.
            int numberOfSeconds = 0;
            try
            {
                numberOfSeconds = int.Parse(stringOfSeconds);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number.");
            }

            if (IsLessThanOrEqualToZero(numberOfSeconds))
            {
                Console.Write("Please enter a positive number.");
            }

            // Task 5:
            // Add an "else" block to the condition from Task 4. This should be run in the case that the
            // number is greater than zero. Write each number to the console, counting backwards, from the 
            // user's number to zero. Then write, "LIFTOFF!".
            // Hint: You can accomplish this with one of several kinds of loops, including "while" and
            //       "for". You can choose whichever you'd like to solve the task. The Microsoft
            //       Developer Network (MSDN) website contains all of the documentation for C#. If you want
            //       to learn more about loops, visit https://msdn.microsoft.com/en-us/library/32dbftby.aspx.
            else
            {
            // This was my way of solving the problem. Works fine, I did learn however, that doing it this way
            // can have some risky behavior later in the code. Trying to reuse the numberOfSeconds variable
            // later can cause unexpected results, because after running through the while loop, numberOfSeconds
            // is now equal to 0 instead of the parsed user entry.
                //while (numberOfSeconds > 0)
                //{
                //    Console.Write(numberOfSeconds + ", ");
                //    numberOfSeconds -= 1;
                //}
                for (int i = numberOfSeconds; i >= 1; i--)
                {
                    Console.WriteLine(i);
                    System.Threading.Thread.Sleep(950);
                }
                Console.WriteLine("LIFTOFF!");
            }

            Console.WriteLine("Press <Enter> to exit...");
            Console.ReadLine();
        }

        static bool IsLessThanOrEqualToZero(int num)
        {
            return num <= 0;
        }
    }
}
