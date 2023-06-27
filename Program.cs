namespace Loop;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Loop";
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        for (int i = 10; i > 0; i--)
        {
            Console.WriteLine(i);
        }

        ///Wait Before Closing.
        Console.ReadKey();
    }
}
