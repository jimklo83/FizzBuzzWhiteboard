﻿namespace FizzBuzz 
{
    class Program 
    {
        string FizzBuzz(int number) 
        {
            if (number % 3 == 0 && number % 5 == 0) 
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0) 
            {
                return "Fizz";
            }
            else if (number % 5 == 0) 
            {
                return "Buzz";
            }
            else 
            {
                return number.ToString();
            }
        }

        Console.WriteLine(FizzBuzz(15));
    }
}


