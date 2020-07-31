using System;
using Xunit;


namespace GradeBook.Tests
{

    public delegate string WriteLogDelegate(string logMessage);

    public class TypeTest
    {   
        int count = 0;

        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage;
            log += ReturnMessage;
            log += IncrementCount;

            var result = log("Hello!");
            Assert.Equal(3, count);
        }

        string ReturnMessage(string message)
        {
            count++;
            return message;
        }

        string IncrementCount(string message)
        {
            count++;
            return message.ToLower();
        }


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