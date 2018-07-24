using System;
using System.Collections.Generic;
using System.Text;

namespace Destine.Ui.Utilities
{
    public static class UiUtilities
    {
        public static string[] ParseInput(string input)
        {
            return input.Split(" ");
        }
    }
}
