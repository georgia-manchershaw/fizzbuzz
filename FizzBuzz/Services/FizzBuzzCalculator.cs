﻿namespace FizzBuzz.Services
{
    public class FizzBuzzCalculator : ICalculator
    { 
        public string GetValue(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";

            if (number % 3 == 0)
                return "Fizz";

            if (number % 5 == 0)
                return "Buzz";

            return number.ToString();
        }
    }
}
