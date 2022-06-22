using System;
using System.Collections.Generic;
using System.Text;

namespace LabOP4
{
    public class Vector3D : TVector
    {

        public Vector3D()
        {
        }
        public Vector3D(double x, double y, double z)
        {
            Coordinates = new double[3];
            Coordinates[0] = x;
            Coordinates[1] = y;
            Coordinates[2] = z;
        }
        public override bool IsParalel(TVector vector)
        {
            if (vector.Coordinates.Length == 3)
            {
                if (Coordinates[0] / vector.Coordinates[0] == Coordinates[1] / vector.Coordinates[1] && Coordinates[1] / vector.Coordinates[1] == Coordinates[2] / vector.Coordinates[2])
                {
                    return true;
                }
            }
            else
                Console.WriteLine("Некорректний формат вектора!");
            return false;
        }

        public override bool IsPerpendicular(TVector vector)
        {
            if (vector.Coordinates.Length == 3)
            {
                if (Coordinates[0] * vector.Coordinates[0] + Coordinates[1] * vector.Coordinates[1] + Coordinates[2] * vector.Coordinates[2] == 0)
                    return true;
            }
            else
                Console.WriteLine("Некорректний формат вектора!");
            return false;
        }

        public override double GetLenght()
        {
            return Math.Sqrt(Math.Pow(Coordinates[0], 2) + Math.Pow(Coordinates[1], 2) + Math.Pow(Coordinates[2], 2));
        }
    }
}
