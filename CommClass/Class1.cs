using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ctrip.Common.Utility;

namespace CommClass
{
    public class Car
    {
       
        public int ID { get; set; }

        public int Money { get; set; }

        object name;

        public object Name
        {
            get { return name; }
            set { name = value; }
        }

        string size;

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public string City { get; set; }

        public Car Clone() //浅CLONE
        {
            return this.MemberwiseClone() as Car;
        }
    }

    public class Adress
    {      
        public string Name { get; set; }
        public string  Country { get; set; }
        public string City { get; set; }
    }

    public class Tel
    {
        public string Telnum { get; set; }
        public string City { get; set; }
    }
}
