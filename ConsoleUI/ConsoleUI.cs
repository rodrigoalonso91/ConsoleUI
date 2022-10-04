using System;

namespace Arcane.ConsoleUI
{
    public static class ConsoleUI
    {
        public static void WriteError(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"##[error] {text}");
            Console.ResetColor();
        }

        public static void WriteInfo(string text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"##[info] {text}");
            Console.ResetColor();
        }

        public static void WriteWarning(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"##[warning] {text}");
            Console.ResetColor();
        }

        public static void WriteCommand(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"##[command] {text}");
            Console.ResetColor();
        }

        public static void WriteOk(string text)
        {
            Console.WriteLine($"##[ok] {text}");
        }

        public static void WriteTitle(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"========== {text} ==========");
            Console.ResetColor();
        }

        public static void WriteCustom(string prefix, string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"##[{prefix}] {text}");
            Console.ResetColor();
        }
    }
}