using System;
using System.Collections.Generic;
using System.Text;

namespace Destine.Ui.Utilities
{
    public static class UiUtilities
    {
        public static void PrintWelcome()
        {
            Console.WriteLine(">>>>> welcome to destine");
        }

        public static string[] ParseInput(string input)
        {
            return input.Split(" ");
        }
    }
}
