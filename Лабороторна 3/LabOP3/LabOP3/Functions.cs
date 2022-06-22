using System;
using System.Collections.Generic;
using System.Text;

namespace LabOP3
{
    public static class Functions
    {
        public static void SetPolinoms(ref Polinom p1, ref Polinom p2, ref Polinom p3)
        {
            p1 = new Polinom();
            p1.FillIndexesFromArray(GetIndexArray(4, 1));
            p1.PolionOut("p1");
            p2 = new Polinom(4);
            p2.FillIndexesFromArray(GetIndexArray(4, 2));
            p2.PolionOut("p2");
            p3 = new Polinom(GetIndexArray(4, 3));
            Console.WriteLine("Indexes of 3 Polinoms");
            Console.WriteLine();
            p1.PolionOut("p1");
            p2.PolionOut("p2");
            p3.PolionOut("p3");
        }
        public static int[] GetIndexArray(int size, int polIndex)
        {
            Console.WriteLine($"Please Enter Indexes For Polinom №{polIndex}. Number of Indexes: {size}");
            int[] indexes = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter Index №{i + 1}");
                indexes[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            return indexes;
        }
    }
}
