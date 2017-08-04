using System;

namespace BoaTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter current number");
            Console.WriteLine("Will be used as the given input for current fibonacci stating at 0.");

            //This will be used as the given input 
            int number = Convert.ToInt32(Console.ReadLine());

            //bool to determine we we should display only even indexs - the first number in Fibonacci 0 is considered to be position 1

            //Test with True
            bool shouldDisplayOnlyEvenIndexes = true;

            BoaQuestionSolution(number, shouldDisplayOnlyEvenIndexes);

            Console.WriteLine("\n");

            //Test with False
            shouldDisplayOnlyEvenIndexes = false;

            BoaQuestionSolution(number, shouldDisplayOnlyEvenIndexes);

            Console.ReadLine();

        }

        private static void BoaQuestionSolution(int number, bool shouldDisplayOnlyEvenIndexes)
        {
            //Assuming we use the modern usage of Fibonacci  we start at 0 and not 1
            //https://en.wikipedia.org/wiki/Fibonacci_number
            Fibonacci(0, 1, 1, number, shouldDisplayOnlyEvenIndexes);
        }

        //https://www.dotnetperls.com/fibonacci        
        //Will not work past the 47th num if we use ints (so we use double)- will display minuses see for ref: 
        //https://www.dotnetperls.com/fibonacci
        public static void Fibonacci(double current, double next, int counterIndex, int number, bool shouldDisplayOnlyEvenIndexes)
        {
            


            if (shouldDisplayOnlyEvenIndexes)
            {
                if (counterIndex % 2 == 0)
                {
                    Console.Write(current);


                    if (counterIndex < number && counterIndex < number)
                    {
                        Console.Write(", ");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                    
                }

                if (counterIndex < number)
                {
                    
                    Fibonacci(next, current + next, counterIndex + 1, number, true);
                }               


            }
            else
            {
                Console.Write(current);

                if (counterIndex < number)
                {
                    Console.Write(" ,");
                    Fibonacci(next, current + next, counterIndex + 1, number, false);
                }
                else
                {
                    if (counterIndex == number)
                    {
                        Console.Write(".");
                    }
                }
            }



         
                
        }

    
    }

}
