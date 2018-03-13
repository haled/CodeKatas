using System;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            var result = 0;

	    if(!string.IsNullOrEmpty(numbers))
	    {
		result = Convert.ToInt32(numbers);
	    }
	    
	    return result;
        }
    }
}
