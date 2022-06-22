using System;
using System.Collections.Generic;

namespace LabOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of 2D Vectors");
            int v2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number of 3D Vectors");
            int v3 = Convert.ToInt32(Console.ReadLine());
            List<Vector2D> vector2Ds = new List<Vector2D>();
            List<Vector3D> vector3Ds = new List<Vector3D>();
            Functions.CreateVectors(vector2Ds, v2, vector3Ds, v3);
            Console.WriteLine(Functions.Find2DParalelLenghtSum(vector2Ds));
            Functions.FindPerpenVectorSum(vector3Ds);
        }
    }
}
