namespace UnitTestsNoFramework.Tests.Interfaces;

public class TestResult<TInput, TOutput>
{
    public string TestName { get; set; }
    public TInput Input { get; set; }
    public TOutput ExpectedOutput { get; set; }
    public TOutput Output { get; set; }
    public bool Result { get; set; }

    public override string ToString()
    {
        return $"Test Name: {TestName}\n" +
               $"Input(s): {Input}\n" +
               $"Expected Output: {ExpectedOutput}\n" +
               $"Output: {Output}\n" +
               $"TestResult: {(Result ? "Passed" : "Failed")}\n";
    }
}