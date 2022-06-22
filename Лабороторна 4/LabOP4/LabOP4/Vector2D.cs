using System;
using System.Collections.Generic;
using System.Text;

namespace LabOP4
{
    public class Vector2D : TVector
    {

        public Vector2D()
        {

        }
        public Vector2D(double x, double y)
        {
            Coordinates = new double[2];
            Coordinates[0] = x;
            Coordinates[1] = y;
        }

        public override bool IsParalel(TVector vector)
        {
            if (vector.Coordinates.Length == 2)
            {
                if (Coordinates[0] / vector.Coordinates[0] == Coordinates[1] / vector.Coordinates[1])
                    return true;
            }
            else
                Console.WriteLine("Некорректний формат вектора!");
            return false;
        }
        public override bool IsPerpendicular(TVector vector)
        {
            if (vector.Coordinates.Length == 2)
            {
                if (Coordinates[0] * vector.Coordinates[0] + Coordinates[1] * vector.Coordinates[1] == 0)
                    return true;
            }
            else
                Console.WriteLine("Некорректний формат вектора!");
            return false;
        }
        public override double GetLenght()
        {
            return Math.Sqrt(Math.Pow(Coordinates[0], 2) + Math.Pow(Coordinates[1], 2));
        }
    }
}
