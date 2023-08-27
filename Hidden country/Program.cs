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
            // settle the punctation lenght
            double len = lines.Length;
            int punctationLength = Convert.ToInt32(Math.Log10(len)) + 3;

            // find the longest line's length
            int longestLineLenght = 0;
            foreach (string line in lines)
            {
                if (line.Length > longestLineLenght)
                {
                    longestLineLenght = line.Length;
                }
            }
            // check if the title is longer that the longest line with punctations (example: 10. line)
            if (title.Length > longestLineLenght + punctationLength)
            {
            
                // draw the box
                Console.WriteLine($"+-{title}-+");
                foreach (string line in lines)
                {
                    int gap = title.Length - longestLineLenght - punctationLength;
                    Console.Write($"| {line}");
                    for (int i = 0; i < gap; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(" |");
                }

            }
        }
    }
}