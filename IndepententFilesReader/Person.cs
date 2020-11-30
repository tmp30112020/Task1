namespace IndepententFilesReader
{
    class Person : IParsedItem
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Hometown { get; set; }
        public int Age { get; set; }

        public bool Initialize(string[] parameters)
        {
            Name = parameters[0];
            Gender = parameters[1];
            Hometown = parameters[2];
            if (int.TryParse(parameters[3], out int result)) Age = result;

            return false;
        }

        public override string ToString()
        {
            return $"{Name} | {Gender} | {Hometown} | { Age}";
        }
    }
}
