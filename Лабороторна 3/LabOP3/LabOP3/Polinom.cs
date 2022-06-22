using System;
using System.Collections.Generic;
using System.Text;

namespace LabOP3
{
    public class Polinom
    {
        public int[] Indexes { get; private set; }
        public Polinom()
        {

        }
        public Polinom(int size)
        {
            Indexes = new int[size];
        }
        public Polinom(int[] indexes)
        {
            Indexes = indexes;
        }
        
        public void FillIndexesFromArray(int[] indexes)
        {
            Indexes = indexes;
        }

        public double CalculatePolinom(int x)
        {
            double sum = 0;
            for (int i = 0; i < Indexes.Length; i++)
            {
                sum += Indexes[i] * Math.Pow(x, i);
            }
            return sum;
        }
        public void PolionOut(string name)
        {
            Console.WriteLine($"Polinom {name}'s Indexes");
            for (int i = 0; i < Indexes.Length; i++)
            {
                Console.WriteLine($"Index no{i+1}: {Indexes[i]}");
            }
            Console.WriteLine();
        }
        public static Polinom operator +(Polinom p1, Polinom p2)
        {
            if (p1.Indexes.Length == p2.Indexes.Length) 
            {
                int[] indxs = new int[p1.Indexes.Length];
                for (int i = 0; i < indxs.Length; i++)
                {
                    indxs[i] = p1.Indexes[i] + p2.Indexes[i];
                }
                Polinom p3 = new Polinom(indxs);
                return p3;
            }
            return null;
        }
        public static Polinom operator -(Polinom p1, Polinom p2)
        {
            if (p1.Indexes.Length == p2.Indexes.Length)
            {
                int[] indxs = new int[p1.Indexes.Length];
                for (int i = 0; i < indxs.Length; i++)
                {
                    indxs[i] = p1.Indexes[i] - p2.Indexes[i];
                }
                Polinom p3 = new Polinom(indxs);
                return p3;
            }
            return null;
        }
        public static Polinom operator +(Polinom p, int n)
        {
            for (int i = 0; i < p.Indexes.Length; i++)
            {
                p.Indexes[i] += n;
            }
            return p;
        }
        public static Polinom operator -(Polinom p, int n)
        {
            for (int i = 0; i < p.Indexes.Length; i++)
            {
                p.Indexes[i] -= n;
            }
            return p;
        }
        public static bool operator ==(Polinom p1, Polinom p2)
        {
            if (p1.Indexes.Length == p2.Indexes.Length)
            {
                bool equals = false;
                for (int i = 0; i < p1.Indexes.Length; i++)
                {
                    if(p1.Indexes[i] == p2.Indexes[i])
                    {
                        equals = true;
                    }
                    else
                    {
                        equals = false;
                        break;
                    }
                }
                return equals;
            }
            return false;
        }
        public static bool operator !=(Polinom p1, Polinom p2)
        {
            if (p1.Indexes.Length == p2.Indexes.Length)
            {
                bool equals = false;
                for (int i = 0; i < p1.Indexes.Length; i++)
                {
                    if (p1.Indexes[i] == p2.Indexes[i])
                    {
                        equals = false;
                    }
                    else
                    {
                        equals = true;
                        break;
                    }
                }
                return equals;
            }
            return true;
        }
    }
}
