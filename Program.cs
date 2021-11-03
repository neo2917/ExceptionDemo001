using System;

namespace ExceptionDemo001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] numbers = new int[2];

            try
            {
                numbers[0] = 0;
                numbers[1] = 1;
                numbers[2] = 2;

                foreach(int i in numbers)
                { 
                    Console.WriteLine(i);
                }
            }
            catch
            {
                Console.WriteLine("An exception was thrown");
            }
        }
    }
}
