using System;

namespace C_Sharp_fizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01 = 1;
            while (num01 <= 100)
            {
                if(num01 % 3 == 0 && num01 % 5 == 0 )
                {
                    Console.WriteLine("FizzBuzz");
                } 
                else if(num01 % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                } 
                else if(num01 % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                } 
                else
                {
                    Console.WriteLine(num01);
                }
                num01++;
            }
            
        }
    }
}
