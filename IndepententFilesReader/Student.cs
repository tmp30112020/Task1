using System;
using System.Globalization;

namespace IndepententFilesReader
{
    class Student : IParsedItem
    { 
        public string Name { get; set; }
        public string Degree { get; set; }
        public string University { get; set; }
        public int Semesters { get; set; }
        public DateTime DateOfMatriculation { get; set; }

        public bool Initialize(string[] parameters)
        {
            Name = parameters[0];
            Degree = parameters[1];
            University = parameters[2];
            if (int.TryParse(parameters[3], out int result)) Semesters = result;
            DateOfMatriculation = DateTime.ParseExact(parameters[4], "dd.MM.yyyy", CultureInfo.InvariantCulture);

            return false;
        }

        public override string ToString()
        {
            return $"{Name}\t|\t{Degree}\t|\t{University}\t|\t{ Semesters}\t|\t{DateOfMatriculation}";
        }
    }
}
