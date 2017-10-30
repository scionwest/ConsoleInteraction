using System;

namespace ConsoleInteraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Line #1");
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.WriteLine("New Message");
            Console.Write("Line #2");

            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write("Line #3");
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.WriteLine("Second Message");
            Console.Write("Line #4");
        }
    }
}
