class Program
{
    public static double Avg(int[] tab)
    {
        double res = 0;
        int counter = 0;
        foreach (int a in tab)
        {
            counter++;
            res += a;
        }

        res = res / counter;
        return res;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int[] tbl = { 1, 2, 3, 4 };

        Console.WriteLine(Avg(tbl));
    }
}