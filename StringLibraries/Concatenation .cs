using System;

namespace StringLibraries
{
    public static class Concatenation
    {
        public static string Concate(this string input)
        {
            return DateTime.Now.ToString() + $" Hello, {input}!";
        }
    }
}
