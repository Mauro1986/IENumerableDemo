using IENumerableDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IENumerableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Garage garage = new Garage();
            //foreach (var item in garage)
            //{
            //    Console.WriteLine(item);
            //}

            Garage garage1 = new Garage();
            foreach (var item in garage1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
