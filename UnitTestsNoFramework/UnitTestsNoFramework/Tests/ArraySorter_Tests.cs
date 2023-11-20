namespace UnitTestsNoFramework.Tests;

public class ArraySorter_Tests
{
    public static void ArraySorter_SortArray_ReturnsSortedArray_FromArrayOfLengthFive()
    {
        // Arrange
        var unsortedArray = new[] { 6, 5, 4, 3, 2, 1 };
        var expectedOutput = new[] { 1, 2, 3, 4, 5, 6 };

        var sut = new ArraySorter();
        // Act
        var output = sut.SortArray(unsortedArray);

        // Assert
        var result = output.SequenceEqual(expectedOutput);
        DisplayResults(unsortedArray, expectedOutput, output, result);

    }

    private static void DisplayResults(int[] unsortedArray, int[] expectedOutput, int[] output, bool result)
    {
        Console.WriteLine($"Input: {String.Join(",", unsortedArray.Select(x => x.ToString()).ToArray())}\n" +
                          $"Expected Output: {String.Join(",",expectedOutput.Select(x => x.ToString()).ToArray())}\n" +
                          $"Output: {String.Join(",", output.Select(x => x.ToString()).ToArray())}\n" +
                          "Test Result: " + (result ? "Passed" : "Failed") + "\n");
    }
}