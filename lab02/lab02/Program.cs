class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Test commit z domu");
        Console.WriteLine("Test");

        int[] tab = new[] { 32, 12, 5, 65, 15 };
        Console.WriteLine(MaxVal(tab));
    }

    public static int MaxVal(int[] tab)
    {
        return tab.Max();
    }
}
