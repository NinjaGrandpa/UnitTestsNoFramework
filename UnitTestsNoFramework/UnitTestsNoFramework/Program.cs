using UnitTestsNoFramework.Tests;

#region Övning 1

Console.WriteLine("Övning 1:\n");

DisplayTestResult(StringInverterTests.InvertString_WhenGivenString_ReturnsReverseString());

#endregion

void DisplayTestResult(bool result)
{
    Console.WriteLine("Test Result: " +  (result ? "PASSED" : "FAILED"));
}
