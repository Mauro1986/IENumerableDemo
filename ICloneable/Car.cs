using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneable
{
    public class Car
    {
        public string Name { get; set; }

        public object Clone()
        {
            return new Car { Name = this.Name };
        }
    }
}
