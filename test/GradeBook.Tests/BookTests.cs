using System;
using Xunit;


namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void CalculateAverageGrade()
        {
        	//arrange
        	var book = new Book("");
        	book.AddGrade(89.1);
        	book.AddGrade(77.3);
        	book.AddGrade(90.5);

        	//act
        	var result = book.getStats();

        	//assert
        	//the expected value, given value, and the precision level/decimal places.
        	Assert.Equal(85.6,result.Average, 1);
        	Assert.Equal(90.5, result.High, 1);
        	Assert.Equal(77.3, result.Low, 1);
        	
        }
    }
}
