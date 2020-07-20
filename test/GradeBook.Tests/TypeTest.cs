using System;
using Xunit;


namespace GradeBook.Tests
{

    public struct Point
    {}

    public class TypeTest
    {

        [Fact]
        public void Test1()
        {
            var x = GetInt();

            Assert.Equal(3, x);
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void GetBookReturnsDiffObjects()
        {
        	var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        	
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}