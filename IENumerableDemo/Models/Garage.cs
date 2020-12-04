using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IENumerableDemo.Models
{
    public class Garage:IEnumerable
    {
        Car[] _cars = new Car[3];

        public Garage()
        {
            _cars[0] = new Car { Name = "Bmw", Year = 2000 };
            _cars[1] = new Car { Name = "Ford", Year = 2005 };
            _cars[2] = new Car { Name = "Volvo", Year = 2007 };
        }

        public IEnumerator GetEnumerator()
        {
            return _cars.GetEnumerator();
        }

    }
}
