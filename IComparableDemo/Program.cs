using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //SIMPELE ARRAY
            //string[] array = { "A","C","D","B" };
            //int[] array = { 1, 2, 3, -4, 5, 7 };
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            ////}

            //Console.WriteLine("-----------------------------------------------");
            //Array.Sort(array);

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            Car[] cars = new Car[3];
            cars[0] = new Car { Name = "Bmw", Year = 2020 };
            cars[1] = new Car { Name = "Audi", Year = 2007 };
            cars[2] = new Car { Name = "Volvo", Year = 2005 };

            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------------");

           // Array.Sort(cars);
            Array.Sort(cars, new CarsHelper());

            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }

        }
    }
}
