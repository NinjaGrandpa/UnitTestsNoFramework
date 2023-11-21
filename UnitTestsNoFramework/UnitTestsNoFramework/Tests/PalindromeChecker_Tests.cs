using System.Reflection;
using UnitTestsNoFramework.Tests.Interfaces;

namespace UnitTestsNoFramework.Tests;

public class PalindromeChecker_Tests
{
    public static void PalindromeChecker_IsPalindrome_ReturnsTrue_FromStringLevel()
    {
        // Arrange
        var wordToCheck = "level";
        var expectedOutput = true;

        var sut = new PalindromeChecker();

        // Act
        var output = sut.IsPalindrome(wordToCheck);

        // Assert
        var testResult = new TestResult<string, bool>
        {
            TestName = MethodBase.GetCurrentMethod().Name,
            Input = wordToCheck,
            ExpectedOutput = expectedOutput,
            Output = output,
            Result = expectedOutput == output
        };

        Console.WriteLine(testResult.ToString());
    }

    public static void PalindromeChecker_IsPalindrome_ReturnsFalse_FromStringPalindrome()
    {
        // Arrange
        var wordToCheck = "palindrome";
        var expectedOutput = false;
        var testResults = new TestResult<string, bool>();

        var sut = new PalindromeChecker();

        // Act
        var output = sut.IsPalindrome(wordToCheck);

        // Assert
        testResults.TestName = MethodBase.GetCurrentMethod().Name;
        testResults.Input =  wordToCheck;
        testResults.ExpectedOutput = expectedOutput;
        testResults.Output =  output;
        testResults.Result = output == expectedOutput;

        Console.WriteLine(testResults.ToString());
    }

    public static void PalindromeChecker_IsPalindrome_ReturnsTrue_FromStringWithCapitalFirstLetter()
    {
        // Arrange
        var wordToCheck = "Racecar";
        var expectedOutput = true;

        var sut = new PalindromeChecker();

        // Act
        var output = sut.IsPalindrome(wordToCheck);

        // Assert
        Console.WriteLine(new TestResult<string, bool>
        {
            TestName = MethodBase.GetCurrentMethod().Name,
            Input =  wordToCheck,
            ExpectedOutput = expectedOutput,
            Output = output,
            Result = output
        }.ToString());
    }

    public static void PalindromeChecker_IsPalindrome_ReturnsTrue_FromEmptyString()
    {
        // Arrange
        var wordToCheck = "";
        var expectedOutput = true;

        var sut = new PalindromeChecker();

        // Act
        var output = sut.IsPalindrome(wordToCheck);

        // Assert
        Console.WriteLine(new TestResult<string, bool>
        {
            TestName = MethodBase.GetCurrentMethod().Name,
            Input = wordToCheck,
            ExpectedOutput = expectedOutput,
            Output = output,
            Result = output
        }.ToString());

    }
}
