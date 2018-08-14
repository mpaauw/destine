using System;
using Destine.Ui.Utilities;

namespace Destine.Ui
{
    class Program
    {
        static void Main(string[] args)
        {
            UiUtilities.PrintWelcome();

            // continue to run program until user ESC
            while(!Console.ReadKey().Equals(ConsoleKey.Escape))
            {
                var input = Console.ReadLine();
                var commands = UiUtilities.ParseInput(input);
            }
        }
    }
}
