using System;
namespace PalindromeExercise
{
	public class Wordsmith
	{
		public bool IsAPalindrome(string word)
		{
            var wordCharrArr = word.ToCharArray();
            Array.Reverse(wordCharrArr);
            var reversed = new string(wordCharrArr);

            if (word.ToLower() == reversed.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
	}
}
