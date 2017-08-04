using System;

namespace BoaTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter current number");
            Console.WriteLine("Will be used as the given input for current fibonacci stating at 0.");

            int number = Convert.ToInt32(Console.ReadLine());

            //Assuming we use the modern usage of Fibonacci  we start at 0 and not 1
            //https://en.wikipedia.org/wiki/Fibonacci_number
            Fibonacci(0, 1, 1, number);

            Console.ReadLine();

        }

        //https://www.dotnetperls.com/fibonacci        
        //Will not work past the 47th num if we use ints (so we use double)- will display minuses see for ref: 
        //https://www.dotnetperls.com/fibonacci
        public static void Fibonacci(double current, double next, int counter, int number)
        {
            Console.Write(current);
            if (counter < number)
            {
                Console.Write(" ,");
                Fibonacci(next, current + next, counter + 1, number);
            }
            else
            {
                if (counter == number)
                {
                    Console.Write(".");
                }
            }
                
        }

    
    }

}
