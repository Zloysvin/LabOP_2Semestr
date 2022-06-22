using System;

namespace LabOP5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String Of Symbols:");
            string symbols = Console.ReadLine();
            Tree tree = new Tree(symbols);
            Functions.Execute(tree);
        }
    }
}
