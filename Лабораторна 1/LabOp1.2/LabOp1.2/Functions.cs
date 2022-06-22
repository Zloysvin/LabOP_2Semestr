using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOp1._2
{
    public static class Functions
    {
        public static List<Car> ReadBinary(List<Car> cars, string path)
        {
            BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open));
            while(reader.PeekChar() > -1)
            {
                string name = reader.ReadString();
                string manufacture = reader.ReadString();
                string service = "";
                Car c = new Car(name, manufacture, service);

                if (c.ManufactureDate[1] - c.ServiceDate[1] <= 2)
                    cars.Add(c);
            }
            return cars;
        }

        public static void ListOutput(List<Car> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Name: " + list[i].Name);
                Console.WriteLine($"Date Of Manufacture: {list[i].ManufactureDate[0]}.{list[i].ManufactureDate[1]}.{list[i].ManufactureDate[2]}");
                Console.WriteLine($"Date Of Service: {list[i].ServiceDate[0]}.{list[i].ServiceDate[1]}.{list[i].ServiceDate[2]}");
            }
        }
    }
}
