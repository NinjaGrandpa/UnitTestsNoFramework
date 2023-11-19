using System.Reflection;
using System.Runtime.CompilerServices;

namespace UnitTestsNoFramework.Tests;

public class StringInverter_Tests
{
    // 1. Enkel strängmanipulation

    // Uppgift: Implementera en metod InvertString som tar en sträng som input och returnerar dess inverterade version.
    
    // Tester: Testa denna metod i Main-metod där du manuellt testar metoden med minst tre olika strängar och skriver ut resultatet samt förväntat resultat.

    public static bool InvertString_WhenGivenString_ReturnsReverseString()
    {
        try
        {
            // Arrange
            var inputString = "Hello, World!";
            var expectedResult = "!dlroW ,olleH";
            StringInverter stringInverter = new StringInverter();

            // Act
            string result = stringInverter.InvertString(inputString);

            // Assert
            DisplayTestResults(MethodBase.GetCurrentMethod().Name, inputString, expectedResult, result);

            return result == expectedResult;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);

            return false;
        }
    }

    private static void DisplayTestResults(string testName, string inputString, string expectedResult, string result)
    {
        Console.WriteLine($"Test Name: {testName}\n\n" +
                          $"Input: {inputString}\n" +
                          $"Expected Result: {expectedResult}\n" +
                          $"Result: {result}\n");
    }

    public static bool InvertString_WhenGivenASecondString_ReturnsReverseString()
    {
        // Arrange
        var inputString = "Hejsanhoppsan världen!";
        var expectedResult = "!nedlräv nasppohnasjeH";

        var sut = new StringInverter();

        // Act
        var result = sut.InvertString(inputString);

        // Assert
        DisplayTestResults(MethodBase.GetCurrentMethod().Name, inputString, expectedResult, result);

        return result == expectedResult;
    }

    public static bool InvertString_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        var inputString = "";
        var expectedResult = "";

        var sut = new StringInverter();

        // Act
        var result = sut.InvertString(inputString);

        // Assert
        DisplayTestResults(MethodBase.GetCurrentMethod().Name, inputString, expectedResult, result);

        return result == expectedResult;
    }
}
