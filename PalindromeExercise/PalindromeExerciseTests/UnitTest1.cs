using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
   public class UnitTest1
    {
        [Theory]
        [InlineData("civic",true)]
        [InlineData("hey", false)]
        [InlineData("RaCeCaR", true)]
        [InlineData("hello", false)]
        [InlineData("mom", true)]
        [InlineData("dad", true)]
        [InlineData("herb", false)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            var wordsmith = new Wordsmith();
            var actual = wordsmith.IsAPalindrome(word);
            Assert.Equal(expected, actual);
           
        }
    }
}
