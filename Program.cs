namespace Loop;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Loop";
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.Write("How many numbers do you want?: ");

        int count = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= count; i++)
        {
            double result = Math.Pow(3, i);
            Console.WriteLine(result);
        }

        ///Wait Before Closing.
        Console.ReadKey();
    }
}
