using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace TJVictor.UT.AppSample
{

    public class MathUtility
    {

        public MathUtility() { }



        public static int Add(int a, int b)
        {

            return a + b;

        }



        public static int Minus(int a, int b)
        {

            return a - b;

        }



        public static int Divide(int a, int b)
        {
            if (b==0)
            {
                return 0;
            }
            return a / b;

        }



        public static int Multiply(int a, int b)
        {

            return a * b;

        }

    }

}

