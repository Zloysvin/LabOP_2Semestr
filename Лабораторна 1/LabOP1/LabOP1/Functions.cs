using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabOP1
{
    public static class Functions
    {
        public static void ReadAndChangeFile(string inPath, string outPath)
        {
            StreamReader sr = new StreamReader(inPath);
            List<string> fileContents = new List<string>();
            while (!sr.EndOfStream)
            {
                fileContents.Add(sr.ReadLine());
            }
            sr.Close();
            StreamWriter sw = new StreamWriter(outPath);
            for (int i = 0; i < fileContents.Count; i++)
            {
                char endLine = fileContents[i][fileContents[i].Length - 1];
                if (endLine != ' ' && endLine != '.' && endLine != ',')
                {
                    sw.WriteLine("-");
                }
                else
                    sw.WriteLine(fileContents[i]);
            }
            sw.Close();
        }
        public static void FileOutput(string path)
        {
            Console.WriteLine("Contents of file " + path + ":");
            Console.WriteLine("=======================");
            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
            Console.WriteLine();
        }
    }
}
