namespace ConsoleMessages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name Character Analyzer");
            Console.WriteLine("-----------------------");

            string name = GetNameFromUser();
            int characterValueTotal = CalculateCharacterValue(name);
            double averageCharacterValue = (double)characterValueTotal / name.Length;

            Console.WriteLine();
            Console.WriteLine($"Hello {name}, it is nice to meet you.");
            Console.WriteLine($"Your name contains {name.Length} characters.");
            Console.WriteLine($"Combined character value: {characterValueTotal}");
            Console.WriteLine($"Average character value: {averageCharacterValue:F2}");
        }

        /// <summary>
        /// Prompts until the user enters a non-empty name.
        /// </summary>
        private static string GetNameFromUser()
        {
            while (true)
            {
                Console.Write("Enter your name: ");
                string? input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input.Trim();
                }

                Console.WriteLine("Please enter at least one character.");
            }
        }

        /// <summary>
        /// Adds the numeric UTF-16 value of each character in the supplied name.
        /// </summary>
        private static int CalculateCharacterValue(string name)
        {
            int total = 0;

            foreach (char character in name)
            {
                total += character;
            }

            return total;
        }
    }
}
