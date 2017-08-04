using System;

namespace BoaTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter current number");
            Console.WriteLine("Will be used as the given input for printing Fibonacci sequence stating at 0.");

            //This will be used as the given input 
            int number = Convert.ToInt32(Console.ReadLine());


            //Test with False
            BoaQuestionSolution(number);

            Console.WriteLine("\n");
            Console.WriteLine("Here is the solution for printing only the even indexes of the sequence");

            //Test with True
            BoaQuestionSolution(number, true);            
            
            Console.ReadLine();

        }


        /// <summary>
        /// Please provide a console application that will display the Fibonacci sequence based on a
        /// given input.  
        /// The given input should indicate how many numbers of the sequence to display.  
        /// So for example, if the user entered 6, their program should display 0, 1, 1, 2, 3, 5.
        /// 
        /// Bonus
        /// Secondary optional input parameter to display only the even indexes of the sequence.  
        /// So, for example, if the user entered "6 true", their program should display 1,2,5. 
        /// </summary>
        ///         
        /// <param name="number">Indicate how many numbers of the sequence to display</param>
        /// <param name="shouldDisplayOnlyEvenIndexes">Secondary optional input parameter to display only the even indexes of the sequence</param>

        private static void BoaQuestionSolution(int number, bool shouldDisplayOnlyEvenIndexes = false)
        {
            //Assuming we use the modern usage of Fibonacci  we start at 0 and not 1
            //https://en.wikipedia.org/wiki/Fibonacci_number
            Fibonacci(0, 1, 1, number, shouldDisplayOnlyEvenIndexes);
        }


        //A recursive function - that will print the Fibonacci sequence.
        //Note: won't work if we use int passed the number 47 (so we use double) see for ref: https://www.dotnetperls.com/fibonacci        
        public static void Fibonacci(double current, double next, int counterIndex, int number, bool shouldDisplayOnlyEvenIndexes)
        {            

            if (shouldDisplayOnlyEvenIndexes)
            {
                PrintEvenIndexsFibonacci(current, next, counterIndex, number);
            }
            else
            {
                PrintFibonacci(current, next, counterIndex, number);
            }         
                
        }

        private static void PrintFibonacci(double current, double next, int counterIndex, int number)
        {
            Console.Write(current);


            if (counterIndex < number)
            {
                Console.Write(", ");
                Fibonacci(next, current + next, counterIndex + 1, number, false);
            }
            else
            {
                Console.Write(".");
            }
                
        }

        private static void PrintEvenIndexsFibonacci(double current, double next, int counterIndex, int number)
        {
            if (counterIndex % 2 == 0)
            {
                Console.Write(current);


                if (counterIndex < number)
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
    }

}
