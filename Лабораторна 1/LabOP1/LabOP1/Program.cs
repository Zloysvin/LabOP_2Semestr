using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Path of Input File Location, with file itself:");
            string inPath = @Console.ReadLine();
            Console.WriteLine("Enter Path Location where you wantto create a new file:");
            string outPath = @Console.ReadLine();
            Console.WriteLine("How do you want to name new text file?");
            outPath += @"\" + Console.ReadLine() + ".txt"; 
            Console.WriteLine();
            Functions.ReadAndChangeFile(inPath, outPath);
            Functions.FileOutput(inPath);
            Functions.FileOutput(outPath);
            Console.ReadLine();
        }
    }
}
