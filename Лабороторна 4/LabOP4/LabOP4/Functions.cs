using System;
using System.Collections.Generic;
using System.Text;

namespace LabOP4
{
    public static class Functions
    {
        public static void CreateVectors(List<Vector2D> vector2Ds, int v2count, List<Vector3D> vector3Ds, int v3count)
        {
            Console.WriteLine("Enter 2D Vectors");
            for (int i = 0; i < v2count; i++)
            {
                Console.WriteLine($"Enter Vector {i+1}'s coordinates");
                Console.WriteLine("Enter Coordinate X");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Coordinate Y");
                int y = Convert.ToInt32(Console.ReadLine());
                vector2Ds.Add(new Vector2D(x, y));
                Console.WriteLine();
            }
            Console.WriteLine("Enter 3D Vectors");
            for (int i = 0; i < v3count; i++)
            {
                Console.WriteLine($"Enter Vector {i + 1}'s coordinates");
                Console.WriteLine("Enter Coordinate X");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Coordinate Y");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Coordinate Z");
                int z = Convert.ToInt32(Console.ReadLine());
                vector3Ds.Add(new Vector3D(x, y, z));
                Console.WriteLine();
            }
        }

        public static double Find2DParalelLenghtSum(List<Vector2D> vector2Ds)
        {
            double sum = 0;
            for (int i = 1; i < vector2Ds.Count; i++)
            {
                if (vector2Ds[0].IsParalel(vector2Ds[i])) 
                {
                    sum += vector2Ds[i].GetLenght();
                }
            }
            return sum;
        }

        public static Vector3D FindPerpenVectorSum(List<Vector3D> vector3Ds)
        {
            Vector3D v3 = new Vector3D(0, 0, 0);
            for (int i = 1; i < vector3Ds.Count; i++)
            {
                if (vector3Ds[0].IsPerpendicular(vector3Ds[i]))
                {
                    v3.Coordinates[0] += vector3Ds[i].Coordinates[0];
                    v3.Coordinates[1] += vector3Ds[i].Coordinates[1];
                    v3.Coordinates[2] += vector3Ds[i].Coordinates[2];
                }
            }
            Console.WriteLine($"Vectors sum equals: {v3.Coordinates[0]}, {v3.Coordinates[1]}, {v3.Coordinates[2]}");
            return v3;
        }
    }
}
