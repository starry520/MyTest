using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommClass;

namespace cloneMember
{
    class Program
    {
        static void Main(string[] args)
        {
            string eid = "";
            if (string.IsNullOrWhiteSpace(eid))
            {

            }

            List<Car> cs = new List<Car>();
            var cc = (from c in cs.DefaultIfEmpty(new Car())
                      where c.ID ==0
                      select c ).Distinct().OrderBy(m=>m).ToList();

            var v = Singleton.GetInstance();

            Car car1 = new Car();
            car1.ID = 1;
            car1.Money = 100;
            car1.Name = "宝马";
            car1.Size = "1号";

            AddMoney(car1,555);

            Car car2 = new Car();
            car2.ID = 2;
            car2.Money = 200;
            car2.Name = "奔驰";
            car2.Size = "1号";

            List<Car> cc1 = new List<Car>();
            cc1.Add(car1);
            cc1.Add(car2);
            List<Car> cc2 = new List<Car>();
            IEnumerable<Car> source =
                  from c in cc1
                   join o in cc2 on new
                  {
                      c.ID,
                      c.Money
                  } equals new
                  {
                      o.ID,
                      o.Money
                  } into os
                 
                  from o2 in os.DefaultIfEmpty(new Car())
                  select new Car
                  {
                      ID=o2.ID,
                      Money=o2.Money,                        
                      Name=o2.Name,
                      Size=o2.Size
                  };
            var list = source.ToList<Car>();

        }

        static void AddMoney(Car car, int money)
        {
            car.Money = car.Money + money;
        }
    }

    public sealed class Singleton
    {
        private static readonly Singleton singleton = new Singleton();
        private Singleton()
        {
        }
        public static Singleton GetInstance()
        {
            return singleton;
        }
    } 

    class DrawBase : System.Object, ICloneable
    {
        public string name = "jmj";
        public DrawBase()
        {
        }
        public object Clone()
        {
            return this as object; //引用同一个对象
           
        }
        public object MemberwiseClone()
        {
           
            return this.MemberwiseClone(); //浅复制
 
        }    
    }

  
}
