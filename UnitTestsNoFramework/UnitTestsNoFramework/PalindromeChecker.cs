namespace UnitTestsNoFramework;

public class PalindromeChecker
{
    public bool IsPalindrome(string wordToCheck)
    {
        wordToCheck = wordToCheck.ToLower();

        var reversedWord = new string(wordToCheck.Reverse().ToArray());
        return reversedWord == wordToCheck;
    }
}