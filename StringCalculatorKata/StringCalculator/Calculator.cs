using System;

namespace StringCalculator
{
    public class Calculator
    {
        private readonly char DEFAULT_DELIMITER = ',';
        private char _delimiter;
        
        public Calculator()
        {
            _delimiter = DEFAULT_DELIMITER;
        }
        
        public int Add(string numbers)
        {
            var result = 0;

            try
            {
  	            if(!string.IsNullOrEmpty(numbers))
	            {
		            var numberList = numbers.Split(_delimiter);
                    foreach(var value in numberList)
                    {
                        result += Convert.ToInt32(value);
                    }
	            }
                return result;
            }
            catch(Exception e)
            {
                throw new Exception("Invalid input values.");
            }
        }

        public void SetDelimiter(char value)
        {
            _delimiter = value;
        }
    }
}
