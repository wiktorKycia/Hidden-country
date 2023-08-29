using System;

namespace HiddenCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintColorMessage(ConsoleColor.Magenta, "Witamy w grze Ukryte Państwo!");
            MakeTitleCage("To ", "pcje", "njhvra", "stara gra", "aa", "bb", "cc", "dd", "ee", "ff", "gg");

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
                // draw the top line with the title in the middle
                Console.WriteLine($"+-{title}-+");

                // draw the inner box
                for (int i = 0; i < lines.Length; i++)
                {
                    // calculate gap for the text line
                    int gap = title.Length - lines[i].Length - punctationLength;

                    // draw a left side of the box
                    Console.Write($"| ");

                    // calculate and draw the punctation gap
                    int punctationGap = punctationLength - 3 - Log10Int(i+1);
                    for (int j = 0; j < punctationGap; j++)
                    {
                        Console.Write(" ");
                    }

                    // write the punctation with the text line
                    Console.Write($"{i+1}. {lines[i]}");

                    // draw the text gap
                    for (int j = 0; j < gap; j++)
                    {
                        Console.Write(" ");
                    }

                    //draw right side of the box
                    Console.WriteLine(" |");
                }

                // draw the bottom side of the box
                Console.Write("+-");
                for (int i = 0; i < title.Length; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("-+");
            }
            else // in this case title is not the longest line
            {
                // draw the beginning of the top line with title
                Console.Write($"+-{title}");

                // draw the rest of the dashes
                for (int i = 0; i < longestLineLenght + punctationLength - title.Length; i++)
                {
                    Console.Write("-");
                }

                // draw the rest of the line
                Console.WriteLine("-+");

                // draw the inner box
                for (int i = 0; i < lines.Length; i++)
                {
                    // calculate gap for the text line
                    int gap = longestLineLenght - lines[i].Length - punctationLength;

                    // draw a left side of the box
                    Console.Write($"| ");

                    // calculate and draw the punctation gap
                    int punctationGap = punctationLength - 3 - Log10Int(i + 1);
                    for (int j = 0; j < punctationGap; j++)
                    {
                        Console.Write(" ");
                    }

                    // write the punctation with the text line
                    Console.Write($"{i + 1}. {lines[i]}");

                    // draw the text gap
                    for (int j = 0; j < gap; j++)
                    {
                        Console.Write(" ");
                    }

                    //draw right side of the box
                    Console.WriteLine(" |");
                }
            }
        }
        static int Log10Int(int a)
        {
            // returns floored int of log10(a)
            return Convert.ToInt32(Math.Floor(Convert.ToDecimal(Math.Log10(Convert.ToDouble(a)))));
        }
    }
}