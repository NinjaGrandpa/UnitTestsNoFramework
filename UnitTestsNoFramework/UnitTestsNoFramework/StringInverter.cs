namespace UnitTestsNoFramework;

public class StringInverter
{
    public string InvertString(string inputString)
    {
        var charArray = inputString.ToCharArray();
        Array.Reverse(charArray);

        return new string(charArray);
    }
}