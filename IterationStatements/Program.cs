using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO - Read each comment and complete its instruction
            // like the example below

            //Create a List called "numbers" - DONE!
            var numbers = new List<int>();

            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num
            //initialize the variable with a value of 0
            //ASNWERED BELOW

            var num = 0;


            // Create a do-while loop and use the template below:
            do
            {
                num++;
                numbers.Add(num);
            } while (num < 100);

            // Then add num to the collection - numbers
            // Hint: reference num inside of the Add method's parentheses

            // <---- While your variable is less than 100
            // ANSWERED BELOW


            // Create a while loop
            while (num < 200) // <--- While num is less than 200
            {
                num++; // Increment num by 1
                numbers.Add(num);
                // Then add num to the collection numbers);
                //HINT: copy how this was done in the do while loop
            }


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");
            foreach (var numv in numbers)
            {
                Console.WriteLine(numv);
            }



            //Create a for loop - this will print the numbers in reverse order - from 200 to 1
            // in you r initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
            // AND as long as i is greater than or equal to 0
            // Decrement i by 1

            //start for loop here
            {
                // place numbers[i] inside of the Console.WriteLine() method
            }

            //------------End of exercise
            // ANSWERED BELOW


            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            for (int i = 199; i < numbers.Count && i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
