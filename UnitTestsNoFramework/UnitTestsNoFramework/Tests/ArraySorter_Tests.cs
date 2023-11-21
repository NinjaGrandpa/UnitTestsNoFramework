namespace UnitTestsNoFramework.Tests;

public class ArraySorter_Tests
{
    private static void DisplayResults(int[] unsortedArray, int[] expectedOutput, int[] output, bool result)
    {
        Console.WriteLine($"Input: {String.Join(",", unsortedArray.Select(x => x.ToString()).ToArray())}\n" +
                          $"Expected Output: {String.Join(",", expectedOutput.Select(x => x.ToString()).ToArray())}\n" +
                          $"Output: {String.Join(",", output.Select(x => x.ToString()).ToArray())}\n" +
                          "TestResult Result: " + (result ? "Passed" : "Failed") + "\n");
    }

    public static void ArraySorter_SortArray_ReturnsSortedArray_FromArrayOfLengthFive()
    {
        // Arrange
        var inputArray = new[] { 6, 5, 4, 3, 2, 1 };
        var expectedOutput = new[] { 1, 2, 3, 4, 5, 6 };

        var sut = new ArraySorter();
        // Act
        var output = sut.SortArray(inputArray);

        // Assert
        var result = output.SequenceEqual(expectedOutput);
        DisplayResults(inputArray, expectedOutput, output, result);

    }

    public static void ArraySorter_SortArray_ReturnsSortedArray_FromArrayOfLengthEight()
    {
        // Arrange
        var unsortedArray = new[] { 5, 8, 8, 4, 8, 9, 5, 1 };
        var expectedOutput = new[] { 1, 4, 5, 5, 8, 8, 8, 9 };

        var sut = new ArraySorter();

        // Act
        var sortedArray = sut.SortArray(unsortedArray);

        // Assert
        var result = sortedArray.SequenceEqual(expectedOutput);
        DisplayResults(unsortedArray, expectedOutput, sortedArray, result);

    }

    public static void ArraySorter_SortArray_ReturnsEmptyArray_FromEmptyArray()
    {
        // Arrange
        var unsortedArray = new int[] { };
        var expectedOutput = new int[] { };

        var sut = new ArraySorter();

        // Act
        var sortedArray = sut.SortArray(unsortedArray);

        // Assert
        var result = sortedArray.SequenceEqual(expectedOutput);
        DisplayResults(unsortedArray, expectedOutput, sortedArray, result);

    }

    public static void ArraySorter_SortArray_ReturnsSortedArray_FromListOfLengthTenWithNegativeNumbers()
    {
        // Act
        var unsortedArray = new[] { -10, -6, 22, -1337, 1337, 66, 1, 0, 123, 6 };
        var expectedOutput = new[] { -1337, -10, -6, 0, 1, 6, 22, 66, 123, 1337 };

        var sut = new ArraySorter();

        // Arrange
        var sortedArray = sut.SortArray(unsortedArray);

        // Assert
        var result = sortedArray.SequenceEqual(expectedOutput);
        DisplayResults(unsortedArray, expectedOutput, sortedArray, result);

    }
}
