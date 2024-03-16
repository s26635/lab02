class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Branch nr 2");
        
        int[] tab = { 32, 12, 5, 65, 15 };
        
        Console.WriteLine(AvgVal(tab));
    }

    public static double AvgVal(int[] tab)
    {
        return tab.Average();
    }
}
