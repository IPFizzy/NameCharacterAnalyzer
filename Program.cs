using System.Diagnostics;

namespace ConsoleMessages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the GitHub Tutorial!");
            Console.WriteLine("Please tell me your name");
            string yourName = Console.ReadLine();
            Console.WriteLine("Hello {0}, I am pleases to meet you", yourName);

            Console.WriteLine("I see that your name is {0} letters long.", yourName.Length);

        }
    }
}