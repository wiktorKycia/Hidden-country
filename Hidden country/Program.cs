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
        static void MakeTitleCage(string title, params string[] lines)
        {
            int longestLineLenght = 0;
            foreach (string line in lines)
            {
                if (line.Length > title.Length && line.Length > longestLineLenght)
                {
                    longestLineLenght = line.Length;
                }
            }
        }
    }
}