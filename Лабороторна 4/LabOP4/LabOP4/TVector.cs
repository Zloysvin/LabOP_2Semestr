using System;
using System.Collections.Generic;
using System.Text;

namespace LabOP4
{
    public abstract class TVector
    {
        public double[] Coordinates { get; set; }
        public abstract bool IsParalel(TVector vector);

        public abstract bool IsPerpendicular(TVector vector);

        public abstract double GetLenght();
    }
}
