using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();

            //Create a variable of type int and initialize the variable with a value of 0 - DONE
            int counter = 0;



            // Create a do-while loop
            do
            {
                // Increment your variable by 1
                counter++;
                // Then add your variable to "numbers" - DONE
                numbers.Add(counter);
            }
            // While your variable is less than 100 - DONE
            while (counter < 100);


            // Create a while loop
            // While your variable is less than 200 - DONE
            while(counter < 200)
            {
                // Increment your variable by 1
                // Then add your variable to "numbers"
                counter++;
                numbers.Add(counter);
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            // Write your variable to the console
            foreach (var number in numbers)
            {
                Console.WriteLine($"{number}");
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" (numbers.Count)
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            for (int i = 199; i <= numbers.Count; i--)
            {
                if (i >= 0) {
                    // Write to the console "numbers" at index i
                    Console.WriteLine(i);
                }
            }
        }
    }
}