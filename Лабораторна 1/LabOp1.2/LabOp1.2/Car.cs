using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOp1._2
{
    public class Car
    {
        public string Name;

        public int[] ManufactureDate;
        public int[] ServiceDate;

        public Car(string name, string dateOfManufacture, string dateOfService)
        {
            Name = name;
            ManufactureDate = SplitDates(dateOfManufacture);
            ServiceDate = SplitDates(dateOfService);
        }

        private int[] SplitDates(string date)
        {
            int[] splitDate = new int[3];
            string[] dates = date.Split('.');
            for (int i = 0; i < 2; i++)
            {
                if (dates[i][0] == '0')
                    splitDate[i] = Convert.ToInt32(dates[i][1].ToString());
                else
                    splitDate[i] = Convert.ToInt32(dates[i]);
            }
            splitDate[2] = Convert.ToInt32(dates[2]);

            return splitDate;
        }
    }
}
