using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car();                      //
            //car.Name = "Audi";                        // shallow copy
            //Car car1 = car;                           // (zoals een snelkoppelinglink)
            //car1.Name = "Kia";      
            //Console.WriteLine("car :" + car.Name);
            //Console.WriteLine("car 1:" + car1.Name);


            Car car = new Car();
            car.Name = "Audi";                    //Deep Copy

            Car car1 = (Car)car.Clone();
            car1.Name = "Kia";

            Console.WriteLine("car :" + car.Name);
            Console.WriteLine("car 1:" + car1.Name);



        }
    }
}
