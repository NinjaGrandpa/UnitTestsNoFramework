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
        DisplayTestResults(a, b, expectedOutput, output, result);
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
        DisplayTestResults(a, b, expectedOutput, output, result);
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
        DisplayTestResults(a, b, expectedOutput, output, result);
    }

    #endregion

    #region Calculator_Multiply

    public static void Calculator_Multiply_ReturnsEight_FromFourAndTwo()
    {
        // Arrange
        var a = 4m;
        var b = 2m;
        var expectedOutput = 8m;

        var sut = new Calculator();

        // Act
        var output = sut.Multiply(a, b);

        // Assert
        var result = output == expectedOutput;
        DisplayTestResults(a, b, expectedOutput, output, result);

    }

    public static void Calculator_Multiply_ReturnsZero_FromFiveAndZero()
    {
        // Arrange
        var a = 5m;
        var b = 0m;
        var expectedOutput = 0m;

        var sut = new Calculator();

        // Act
        var output = sut.Multiply(a, b);

        // Assert
        var result = output == expectedOutput;
        DisplayTestResults(a, b, expectedOutput, output, result);
    }

    public static void Calculator_Multiply_ReturnsMinusTwentyFour_FromSixAndNegativeFour()
    {
        // Arrange
        var a = 6m;
        var b = -4m;
        var expectedOutput = -24m;

        var sut = new Calculator();

        // Act
        var output = sut.Multiply(a, b);

        // Assert
        var result = output == expectedOutput;
        DisplayTestResults(a, b, expectedOutput, output, result);
    }

    #endregion

    #region Calculator_Divide

    public static void Calculator_Divide_ReturnThirtyTwo_FromSixtyFourAndTwo()
    {
        // Arrange
        var a = 64m;
        var b = 2m;
        var expectedOutput = 32m;

        var sut = new Calculator();

        // Act
        var output = sut.Divide(a, b);

        // Assert
        var result = output == expectedOutput;
        DisplayTestResults(a, b, expectedOutput, output, result);

    }

    public static void Calculator_Divide_ReturnFifty_FromTwentyFiveAndPointFive()
    {
        // Arrange
        var a = 25m;
        var b = 0.5m;
        var expectedOutput = 50m;

        var sut = new Calculator();

        // Act
        var output = sut.Divide(a, b);

        // Assert
        var result = output == expectedOutput;
        DisplayTestResults(a, b, expectedOutput, output, result);

    }

    #endregion
}
