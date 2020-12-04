using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableDemo
{
    public class Car : IComparable
    {

        public string Name { get; set; }
        public int Year { get; set; }

        public int CompareTo(object obj)
        {
            Car carTemp = obj as Car;
            if (carTemp != null)
            {
                if (this.Year > carTemp.Year)
                {
                    return 1;
                }
                else if (this.Year < carTemp.Year)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
                //return this.Year.CompareTo(carTemp.Year);    andere manier, zelfde effect
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"Name {Name}   Year {Year}";
        }
    }
}
