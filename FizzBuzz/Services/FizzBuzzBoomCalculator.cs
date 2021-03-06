﻿namespace FizzBuzz.Services
{
    public class FizzBuzzBoomCalculator : ICalculator
    {
        private ICalculator _calculator;

        public FizzBuzzBoomCalculator(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public string GetValue(int number)
        {
            string result = _calculator.GetValue(number);

            if (result.Contains("1"))
            {
                return "Boom";
            }

            return result;
        }
    }
}
