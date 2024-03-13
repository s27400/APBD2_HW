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

    public static int Max(int[] tab)
    {
        int max = 0;
        foreach (int a in tab)
        {
            if (max < a)
            {
                max = a;
            }
        }

        return max;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int[] tbl = { 1, 2, 3, 4, 0, 10, 5 };

        Console.WriteLine(Avg(tbl));
        Console.WriteLine(Max(tbl));
    }
}