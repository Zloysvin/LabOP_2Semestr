using System;

namespace LabOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Polinom p1 = new Polinom();
            Polinom p2 = new Polinom();
            Polinom p3 = new Polinom();
            Functions.SetPolinoms(ref p1, ref p2, ref p3);
            Console.WriteLine("Enter Add/Substarct Value:");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            p1 = p1 + value;
            p2 = p2 - value;
            p1.PolionOut("p1");
            p2.PolionOut("p2");
            Console.WriteLine($"Are Indexes Of p1 And p2 Are Equal? - {p1 == p2}");
            Console.WriteLine();
            Console.WriteLine("Please Enter Value X To Calculate Polinom p3:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Result Of Polinom p3 With X = {x}, is: {p3.CalculatePolinom(x)}");
        }
    }
}
