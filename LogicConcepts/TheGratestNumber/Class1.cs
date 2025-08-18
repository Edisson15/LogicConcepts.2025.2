using System;
using System.Collections.Generic;

public static class ConsoleExtension
{
    public static int GetInt(string message)
    {
        int value;
        string input;

        do
        {
            Console.Write(message);
            input = Console.ReadLine();
        }
        while (!int.TryParse(input, out value));

        return value;
    }

    public static string GetValidOptions(string message, List<string> options)
    {
        string input;
        do
        {
            Console.Write(message);
            input = Console.ReadLine().ToLower();
        }
        while (!options.Contains(input));

        return input;
    }
}
