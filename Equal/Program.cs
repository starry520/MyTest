using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommClass;

namespace Equal
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeOffset dtos = DateTimeOffset.Now;
            string t1 = dtos.ToString();

            string name1 = "baoma";
            string name2 = "baoma";
            Car car1 = new Car();
            car1.ID = 123;
            car1.Name = "baoma";

            Car car2 = new Car();
            car2.ID = 123;
            car2.Name = "baoma";

            car2.Name = "baoma1";
            bool b12 = car1.Name.Equals(car2.Name);
            car2.Name = "baoma";

            bool b1 = car1.Equals(car2);
             b12 = car1.Name.Equals(car2.Name);
            bool b13 = name1.Equals(name2);
            bool b14 = name1.Equals(car2.Name);
        }
    }
}
