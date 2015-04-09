using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jstest
{    

    class Program
    {
        static Car c = new Car();
        static void Main(string[] args)
        {

            c.Name = "liu";
            Car d = SetNewCar(c);
        }

        private static Car SetNewCar(Car d)
        {
            d.Name = "starry";
            d.Size = 12;
            Console.WriteLine(ReferenceEquals(c, d)); //指向同一个内存地址  fase
            d = new Car();
            Console.WriteLine(ReferenceEquals(c, d)); //指向不同的内存地址 false
            return d;
        }
    }

    public struct Car
    {
        public string Name { get; set; }
        public int Size { get; set; }
    }
}
