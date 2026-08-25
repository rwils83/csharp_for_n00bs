namespace ConsoleApp1;

public static class Demo
{
    public static int GetThirdElement(int[] values)
    {
        if (values.Length < 3)
        {
            throw new ArgumentException("Array must have at least 3 elements.", nameof(values));
        }

        return values[2];
    }

    public static string DescribeTuple((string First, string Second, int Count) tuple)
    {
        return $"{tuple.First} / {tuple.Second} (count: {tuple.Count})";
    }
}
