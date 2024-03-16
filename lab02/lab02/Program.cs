class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Test commit z domu");
        Console.WriteLine("Test");

        int[] tab = { 32, 12, 5, 65, 15 };
        Console.WriteLine(AvgValOfArray(tab));
        Console.WriteLine(MaxVal(tab));
    }

    public static double AvgValOfArray(int[] tab)
    {
        int sum = 0;
        for (int i = tab.Length - 1; i >= 0; i--)
        {
            sum += tab[i];
        }
        int result = sum / tab.Length;
        return result;
    }

    public static int MaxVal(int[] tab)
    {
        return tab.Max();
    }
}
