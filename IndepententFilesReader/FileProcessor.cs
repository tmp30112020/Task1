using System;
using System.Collections.Generic;
using System.IO;

namespace IndepententFilesReader
{
    class FileProcessor<T> where T : IParsedItem, new()
    {
        string filePath;
        string ignoreString = new string('-', 10); // TODO: Ignore string get from config
        bool isHeader = true;
        string separator;
        public List<T> LineObjects { get; set; }

        public FileProcessor(string filePath, string separator)
        {
            LineObjects = new List<T>();
            this.filePath = filePath;
            this.separator = separator;
            if (!File.Exists(filePath))
                Console.WriteLine($"Cant find file by path: {filePath}");
        }

        public bool ProcessFile()
        {
            foreach (var rowLine in File.ReadAllLines(filePath))
            {
                var line = rowLine.Trim();
                if (string.IsNullOrEmpty(line) || line.IndexOf(ignoreString) >= 0)
                    continue;
                var columned = line.Split(separator.ToCharArray());
                if (columned.Length != typeof(T).GetProperties().Length)
                {
                    Console.WriteLine($"Wrong line in file: {filePath} at  ...."); // TODO: position
                    continue;
                }
                if (isHeader)
                {
                    isHeader = false;
                    continue;
                }

                var t = new T();
                t.Initialize(columned);
                LineObjects.Add(t);
            }
            return true;
        }
    }
}
