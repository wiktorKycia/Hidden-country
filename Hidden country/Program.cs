using System;

namespace HiddenCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintColorMessage(ConsoleColor.Magenta, "Witamy w grze Ukryte Państwo!");
        }
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}