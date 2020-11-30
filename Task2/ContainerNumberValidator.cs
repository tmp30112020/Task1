using System;

namespace Task2
{
    public class ContainerNumberValidator : IValidator
    {
        readonly ICharDecoder alphasymbolDecoder;
        readonly ICharDecoder numberDecoder;
        int digitsNumber = 11;

        public ContainerNumberValidator()
        {
            alphasymbolDecoder = new AlphasymbolDecoder();
            numberDecoder = new NumberDecoder();
        }

        public ContainerNumberValidator(int digitsNumber) : this()
        {
            this.digitsNumber = digitsNumber;
        }

        public bool IsValid(string input)
        {            
            if (String.IsNullOrEmpty(input))
            {
                // throw new ArgumentNullException("Checked string could not be empty");
                // TODO: write to log: "Checked string could not be empty"
                return false;
            }

            string trimmedInput = input.Trim().ToUpper();
            if (trimmedInput.Length != digitsNumber)
            {
                // throw new ArgumentException($"Incorrect lenghts of input :'{trimmedInput}'");
                // TODO: write to log: $"Incorrect lenghts of input :'{trimmedInput}'"
                return false;
            }

            if (!Char.IsDigit(trimmedInput[trimmedInput.Length - 1]))
            {
                // throw new ArgumentException($"Last element in input should be Digit :'{trimmedInput}'");
                // TODO: write to log: $"Last element in input should be Digit :'{trimmedInput}'"
                return false;

            }

            double summ = CalculateSumm(trimmedInput);
            int devideResult = (int)summ / digitsNumber;
            int multiplyResult = devideResult * digitsNumber;

            return (summ - multiplyResult == numberDecoder.Decode(trimmedInput[trimmedInput.Length - 1]));
        }

        private double CalculateSumm(string trimmedInput)
        {
            double summ = 0;
            for (int i = 0; i < trimmedInput.Length - 1; i++)
            {
                char symbol = trimmedInput[i];
                if (Char.IsLetterOrDigit(symbol))
                {
                    summ += (Char.IsDigit(symbol)
                            ? numberDecoder.Decode(symbol)
                            : alphasymbolDecoder.Decode(symbol)) * (Math.Pow(2, i));

                }
                else
                {
                    // throw new ArgumentException($"Used Incorrect symbol '{trimmedInput[i]}' at position: {i} in input '{trimmedInput}'");
                    // TODO: write to log: $"Used Incorrect symbol '{trimmedInput[i]}' at position: {i} in input '{trimmedInput}'"
                }
            }

            return summ;
        }
    }
}
