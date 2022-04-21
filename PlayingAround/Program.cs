using System;

namespace PlayingAround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that counts from 1 to 10 three times, using the while,
            //do ...while, and for statements, and outputs the results to the screen.

            int count = 1;
            Console.WriteLine("\ndo loop");
            while (count <= 10)
            {
                Console.WriteLine(count);
                count++;
            }


            Console.WriteLine("\ndo while loop");
            count = 1;
            do
            {
                Console.WriteLine(count);
                count++;
            } while (count <= 10);

            Console.WriteLine("\nfor loop");
            count = 1;

            for (; count <= 10; count++)
            {
                Console.WriteLine(count);
            }


            //Create a program that prompts a user for input, accepts an integer,
            //then evaluates whether that input is zero, odd or even, a multiple of 10,
            //or too large (more than 100) by using multiple levels of if statements.

            Console.Write("Type an integer: ");
            int num = Int32.Parse(Console.ReadLine());

            if (num == 0) Console.WriteLine("This equals zero");
            Console.WriteLine(num % 2 == 1 ? "Odd" : "Even");
            Console.WriteLine(num % 10 == 0 ? "Multiple of 10" : "Not a multiple of 10");
            if (num > 100) Console.WriteLine("Too big");

            // make a
            // switch statement.


            Console.Write("Enter top, bottom, left, or right: ");
            string direction = Console.ReadLine();

            switch (direction)
            {
                case "top":
                    Console.WriteLine("North");
                    break;
                case "right":
                    Console.WriteLine("East");
                    break;
                case "bottom":
                    Console.WriteLine("South");
                    break;
                case "left":
                    Console.WriteLine("West");
                    break;
                default:
                    Console.WriteLine("Yo thats not a direction");
                    break;
            }


            //Create a program that initializes a variable x at 0 and counts up,
            //and initializes a second variable y at 25 and counts down. Use a
            //single for loop to increment x and decrement y simultaneously,
            //and output the values of x and y at each iteration of the loop.
            //When x is greater than y, end the loop and print out the message “Crossed over!”

            int x = 0;
            int y = 25;
            for (; y > 0; x++)
            {
                Console.WriteLine($"x = {x}");
                Console.WriteLine($"y = {y}\n");
                if (x > y)
                {
                    Console.WriteLine("Crossed over!");
                    break;
                }
                y--;
            }
            
        }
    }
}
