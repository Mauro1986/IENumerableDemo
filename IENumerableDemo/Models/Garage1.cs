using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IENumerableDemo.Models
{
    public class Garage1
    {
        private Car bmw, ford, volvo;

        public Garage1()
        {
            bmw = new Car() {Name = "Bmw", Year = 2000 };
            ford = new Car() {Name = "Ford", Year = 2000 };
            volvo = new Car() {Name = "Volvo", Year = 2000 };
        }

        public IEnumerable GetEnumerator()
        { 
            yield return bmw;
            yield return ford;
            yield return volvo;
        }

    }
}
