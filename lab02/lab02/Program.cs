class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Test commit z domu");
        Console.WriteLine("Test");

        int[] tab = { 32, 12, 5, 65, 15 };
        Console.WriteLine(AvgVal(tab));
        Console.WriteLine(MaxVal(tab));
    }

    public static double AvgVal(int[] tab)
    {
        return tab.Average();
    }

    public static int MaxVal(int[] tab)
    {
        return tab.Max();
    }
}
