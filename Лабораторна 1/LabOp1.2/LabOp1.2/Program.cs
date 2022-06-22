using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOp1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Admin\Desktop\KPI\semestr2\ОП\Лабораторна 1\LabOp1.2\cars_catalog.dat";
            List<Car> cars = new List<Car>();
            cars = Functions.ReadBinary(cars, path);
            Functions.ListOutput(cars);
        }
    }
}
