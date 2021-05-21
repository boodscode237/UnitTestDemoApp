using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

//Arrange, Act, Assert
// expected and actual
namespace DemoLibrary.Tests
{
    public class DisplayMessagesTests
    {
        [Fact]
        public void GreetingShouldReturnGoodMorningMessage()
        {
            // Arrange
            DisplayMessagesClass messages = new DisplayMessagesClass();
            string expected = "Good morning Donny";

            // Act
            string actual = messages.Greeting("Donny", 6);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreetingShouldReturnGoodAfternoonMessage()
        {
            // Arrange
            DisplayMessagesClass messages = new DisplayMessagesClass();
            string expected = "Good afternoon Donny";

            // Act
            string actual = messages.Greeting("Donny", 16);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Joe", 0, "Good morning Joe")]
        [InlineData("Joe", 1, "Good morning Joe")]
        [InlineData("Joe", 2, "Good morning Joe")]
        [InlineData("Joe", 4, "Good day Joe")]
        [InlineData("Joe", 5, "Good morning Joe")]
        [InlineData("Joe", 6, "Good morning Joe")]
        [InlineData("Joe", 7, "Good morning Joe")]
        public void GreetingShouldReturnExpectedValue(
            string firstName,
            int hourOfTheDay,
            string expected)
        {
            // Arrange
            DisplayMessagesClass messages = new DisplayMessagesClass();

            // Act
            string actual = messages.Greeting(firstName, hourOfTheDay);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
