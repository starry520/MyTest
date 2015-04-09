using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DictionaryTest
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Dictionary<int, int> coutryDic = new Dictionary<int, int>();
            List<int> coutryDic=new List<int> ();
            for (int i = 0; i < 4; i++)
            {
                coutryDic.Add(i);      
            }

            int index=0;
            while (true)
            {
                List<int> tt = coutryDic.Skip(index++ * 2).Take(2).ToList();               
            }

        }
    }
}
