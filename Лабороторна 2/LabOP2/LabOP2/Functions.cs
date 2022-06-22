using System;
using System.Collections.Generic;
using System.Text;

namespace LabOP2
{
    public static class Functions
    {
        public static void FillArray(Word[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"Enter word number {i + 1}");
                words[i] = new Word(Console.ReadLine());
            }
        }
        public static Word FindLargestNumbers(Word[] words)
        {
            int largetsIndex = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].CountNumbersInWord() > words[largetsIndex].CountNumbersInWord())
                    largetsIndex = i;
            }
            if (words[largetsIndex].CountNumbersInWord() == 0)
                Console.WriteLine("There are no words with numbers");
            return words[largetsIndex];
        }
    }
}
