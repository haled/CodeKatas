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
            Calculator testObject = new Calculator();
            var result = testObject.Add("");
            Assert.Equal(0, result);
        }

	[Fact]
	public void AddSingleNumberReturnsItself()
	{
	    Calculator testObject = new Calculator();
	    var result = testObject.Add("1");
	    Assert.Equal(1, result);
	}
    }
}
