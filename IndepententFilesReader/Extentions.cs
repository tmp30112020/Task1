using System;
using System.Collections.Generic;

namespace IndepententFilesReader
{
    public static class Extentions
    {
        public static void Print<T>(this IEnumerable<T> elements) where T : IParsedItem
        {
            Console.WriteLine($"Report from {typeof(T).Name}"); // TODO: Change CW to Debug or LOG
            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
