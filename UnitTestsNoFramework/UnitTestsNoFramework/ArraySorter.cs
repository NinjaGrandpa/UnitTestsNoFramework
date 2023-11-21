namespace UnitTestsNoFramework;

public class ArraySorter
{
    public int[] SortArray(int[] unsortedArray)
    {
        var sortedArray = unsortedArray.Order().ToArray();
        return sortedArray;
    }
}