/*
 * Author: Ron Jeremy Reyes
 * Course: COMP-003A
 * Purpose: Assignment for week 4
 */
namespace COMP003A.Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* For Loop Section (Right Triangle) */
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("for loop section");
            Console.WriteLine("Output a right triangle based on user input");
            Console.WriteLine("".PadRight(50, '*'));
            Console.Write("Enter a positive whole number: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            string output = "";

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine($"{output += "#"}");
            }
            Console.WriteLine("\n");

            /* For Each Section (Friends) */
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("foreach Section");
            Console.WriteLine("Output all of the friends in an array");
            Console.WriteLine("".PadRight(50, '*'));

            string[] friends = { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };

            foreach (string name in friends)
            {
                Console.WriteLine($"{name}");
            }
            Console.WriteLine("\n");

            /* Do-While Loop Section */
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("do-while Section");
            Console.WriteLine("Output 0-50 by 5s");
            Console.WriteLine("".PadRight(50, '*'));

            int counter = 0;
            do
            {
                Console.WriteLine(counter);
                counter += 5;
            } while (counter <= 50);
            Console.WriteLine("\n");

            /* While Loop Section */
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("while Section");
            Console.WriteLine("Ouput 1-20");
            Console.WriteLine("If the number is divisible by 2, output Foo");
            Console.WriteLine("If the number is divisible by 5, output Bar");
            Console.WriteLine("If the number is divisible by 2 & 5, ouput FooBar");
            Console.WriteLine("".PadRight(50, '*'));

            int counter2 = 1;

            while (counter2 <= 20)
            {
                if (counter2 % 2 == 0)
                {
                    if (counter2 % 2 == 0 && counter2 % 5 == 0) // checks first value if both divisible by 2 & 5 
                    {
                        Console.WriteLine("FooBar");
                    }
                    else if (counter2 % 2 == 0)  // if not divisible by 2 & 5 
                    {
                        Console.WriteLine("Foo");
                    }
                }
                else if (counter2 % 5 == 0)
                {
                    Console.WriteLine("Bar");
                }                
                else
                {
                    Console.WriteLine(counter2);
                }
                counter2++;
            }
        }
    }
}