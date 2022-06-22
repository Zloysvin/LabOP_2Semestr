using System;

namespace LabOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of Words");
            int n = Convert.ToInt32(Console.ReadLine());
            Word[] words = new Word[n];
            Functions.FillArray(words);
            Word target = Functions.FindLargestNumbers(words);
            Console.WriteLine($"Largest number of numbers is in the word: {target.Content}; number of numbers: {target.CountNumbersInWord()}");
        }
    }
}
