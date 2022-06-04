namespace BankV2.IO;
public static class Input
{
    public static void Open(out string input, string writeLine, string error)
    {
        Console.Write(writeLine);

        input = Console.ReadLine().Trim();

        while (string.IsNullOrEmpty(input))
        {
            Console.Write($"{error}. Recommencez : ");
            input = Console.ReadLine().Trim();
        }
    }

    public static string OpenIf(out string input, string writeLine, string error, Func<string, bool> predicate)
    {
        Console.Write(writeLine);

        input = Console.ReadLine().Trim();

        while (string.IsNullOrEmpty(input) || !predicate(input))
        {
            Console.Write($"{error}. Recommencez : ");
            input = Console.ReadLine().Trim();
        }

        return input;
    }
}