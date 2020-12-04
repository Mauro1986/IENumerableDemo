using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableDemo
{
    public class CarsHelper : IComparer
    {
        public int Compare(object x, object y)
        {
            Car car1 = x as Car;
            Car car2 = y as Car;

            if (car1 != null && car2 != null)
            {
               return string.Compare(car1.Name, car2.Name, StringComparison.OrdinalIgnoreCase);

               // return car1.CompareTo(car2);
            }
            else
            {
                return 0;
            }
        }
    }
}
