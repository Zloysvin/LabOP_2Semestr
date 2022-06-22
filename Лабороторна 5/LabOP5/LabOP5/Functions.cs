using System;
using System.Collections.Generic;
using System.Text;

namespace LabOP5
{
    public static class Functions
    {
        public static void Execute(Tree tree)
        {
            Console.WriteLine("Enter Target Symbol");
            char target = Convert.ToChar(Console.ReadLine());
            bool IsFound = false;
            int height = 0;
            tree.FindHeight(tree.Root, ref height, 0, ref IsFound, target);
            Console.WriteLine($"Height Of Char {target} is {height}");
            tree.OutTree();
        }
    }
}
