using System;
using Xunit;
using StringCalculator;
    
namespace StringCalculatorTests
{
    public class Calculator_UT
    {
        [Fact]
        public void AddEmptyStringReturnsZero()
        {
            ICalculator testObject = new Calculator();
            var result = testObject.Add("");
            Assert.Equal(0, result);
        }

    	[Fact]
	    public void AddSingleNumberReturnsItself()
	    {
	        ICalculator testObject = new Calculator();
	        var result = testObject.Add("1");
	        Assert.Equal(1, result);
	    }

        [Fact]
        public void AddTwoNumbersSeparatedByComma()
        {
            ICalculator testObject = new Calculator();
            var result = testObject.Add("2,3");
            Assert.Equal(5, result);
        }

        [Fact]
        public void AddMoreThanTwoNumbersSeparatedByComma()
        {
            ICalculator testObject = new Calculator();
            var result = testObject.Add("1,2,3,4");
            Assert.Equal(10, result);
        }

        [Fact]
        public void CanSpecifyTheListDelimiter()
        {
            ICalculator testObject = new Calculator();
            testObject.SetDelimiter('|');
            var result = testObject.Add("1|2|3|4");
            Assert.Equal(10, result);
        }

        [Fact]
        public void AddThrowsExceptionWithUnrecognizableInput()
        {
            ICalculator testObject = new Calculator();
            Exception ex = Assert.Throws<Exception>(() => testObject.Add("abcd"));
            Assert.Equal("Invalid input values.", ex.Message);
        }
    }
}
