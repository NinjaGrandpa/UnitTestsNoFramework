namespace UnitTestsNoFramework.Tests;

public class Calculator_Tests
{
    private static void DisplayTestResults(decimal inputA, decimal inputB, decimal expectedOutput, decimal output, bool result)
    {
        Console.WriteLine($"Input: {inputA}, {inputB}\n" +
                          $"Expected Output: {expectedOutput}\n" +
                          $"Output: {output}\n" +
                          "Test Result: " + (result ? "Passed" : "Failed") + "\n");
    }

    #region Calculator_Add

    public static void Calculator_Add_ReturnsThree_FromOneAndTwo()
    {
        // Arrange
        decimal a = 1;
        decimal b = 2;
        decimal expectedOutput = 3;

        var sut = new Calculator();

        // Act
        var output = sut.Add(a, b);

        // Assert
        var result = output == expectedOutput;
        DisplayTestResults(a, b, expectedOutput, output, result);
    }

    public static void Calculator_Add_ReturnsFour_FromTwoAndTwo()
    {
        // Arrange
        decimal a = 2;
        decimal b = 2;
        decimal expectedOutput = 4;

        var sut = new Calculator();

        // Act
        var output = sut.Add(a, b);

        // Assert
        var result = output == expectedOutput;
        DisplayTestResults(a, b, expectedOutput, output, result);
    }

    public static void Calculator_Add_ReturnsNegativeTwo_FromTwoAndNegativeFour()
    {
        // Arrange
        decimal a = 2;
        decimal b = -4;
        decimal expectedOutput = -2;

        var sut = new Calculator();

        // Act
        var output = sut.Add(a, b);

        // Assert
        var result = output == expectedOutput;
        DisplayTestResults(a, b, expectedOutput, output, result);
    }

    #endregion


    #region Calculator_Subtract

    public static void Calculator_Subtract_ReturnsTwo_FromThreeAndOne()
    {
        // Arrange
        decimal a = 3;
        decimal b = 1;
        decimal expectedOutput = 2;

        var sut = new Calculator();

        // Act
        var output = sut.Subtract(a, b);

        // Assert
        var result = output == expectedOutput;
        DisplayTestResults(a,b,expectedOutput,output,result);
    }

    public static void Calculator_Subtract_ReturnFourPointFour_FromEightPointEightAndFourPointFour()
    {
        // Arrange
        var a = 8.8m;
        var b = 4.4m;
        var expectedOutput = 4.4m;

        var sut = new Calculator();

        // Act
        var output = sut.Subtract(a, b);

        // Assert
        var result = output == expectedOutput;
        DisplayTestResults(a,b,expectedOutput,output,result);
    }

    public static void Calculator_Subtract_ReturnNegativeTen_FromNegativeFiveAndFive()
    {
        // Arrange
        decimal a = -5;
        decimal b = 5;
        decimal expectedOutput = -10;

        var sut = new Calculator();

        // Act
        var output = sut.Subtract(a, b);

        // Assert
        var result = output == expectedOutput;
        DisplayTestResults(a,b,expectedOutput, output, result);
    }

    #endregion

    #region Calculator_Multiply

    public static void Calculator_Multiply

    #endregion
}
