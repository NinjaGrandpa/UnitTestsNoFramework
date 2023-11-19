namespace UnitTestsNoFramework;

public class Calculator
{
    public decimal Add(decimal a, decimal b)
    {
        return a + b;
    }

    public decimal Subtract(decimal a, decimal b)
    {
        return a-b;
    }

    public decimal Multiply(decimal a, decimal b)
    {
        throw new NotImplementedException();
    }

    public decimal Divide(decimal a, decimal b)
    {
        throw new NotImplementedException();
    }
}
