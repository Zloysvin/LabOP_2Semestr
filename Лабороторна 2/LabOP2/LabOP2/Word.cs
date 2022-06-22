using System;
using System.Collections.Generic;
using System.Text;

namespace LabOP2
{
    public class Word
    {
        public string Content { get; set; }

        string numbers = "0123456789";

        public Word()
        {

        }

        public Word(string content)
        {
            Content = content;
        }

        public int CountNumbersInWord()
        {
            int count = 0;
            for (int i = 0; i < Content.Length; i++)
            {
                if (numbers.Contains(Content[i]))
                    count++;
            }
            return count;
        }
    }
}
