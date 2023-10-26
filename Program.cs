namespace FizzBuzz 
{
    public class Program 
    {
        //FizzBuzz that takes in an integer as parameter and returns a string
        public string FizzBuzz(int number) 
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

        //FizzBuzz that takes in an integer array as parameter and returns a string array
        public string[] FizzBuzz(int[] array) 
        {
            var fizzBuzz = new string[array.Length];

            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] % 3 == 0 && array[i] % 5 == 0) 
                {
                    fizzBuzz[i] = "FizzBuzz";
                }
                else if (array[i] % 3 == 0) 
                {
                    fizzBuzz[i] = "Fizz";
                }
                else if (array[i] % 5 == 0) 
                {
                    fizzBuzz[i] = "Buzz";
                }
                else 
                {
                    fizzBuzz[i] = array[i].ToString();
                }
            }
            return fizzBuzz;
        }
    }
}


