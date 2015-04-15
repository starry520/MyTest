using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private void GetList<T>(T oldValue, T newValue)
        {
            T t = Activator.CreateInstance<T>();   

             foreach (System.Reflection.PropertyInfo info in typeof(T).GetProperties())
                {
                    object oldPropertyValue = info.GetValue(oldValue, null);
                    object newPropertyValue = info.GetValue(newValue, null);
                    if (oldPropertyValue != newPropertyValue)
                    {
                        DescriptionAttribute[] arrDesc = (DescriptionAttribute[])info.GetCustomAttributes(typeof(DescriptionAttribute), false);
                        if (arrDesc == null || arrDesc.Length == 0)
                        {
                            continue;
                        }                     
                    }
                }
        }
    }
}
