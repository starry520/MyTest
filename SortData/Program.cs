using System;
using System.Collections.Generic;

namespace SortData
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 6, 2, 4, 1, 5, 9 };
            insertion_sort(x);
            foreach (var item in x)
            {
                if (item > 0)
                    Console.WriteLine(item + ",");
            }
            Console.ReadLine();
        }



        /// <summary>
        /// 插入排序
        /// </summary>
        /// <param name="unsorted"></param>
        static void insertion_sort(int[] unsorted)
        {
            for (int i = 1; i < unsorted.Length; i++)
            {
                if (unsorted[i - 1] > unsorted[i])
                {
                    int temp = unsorted[i];
                    int j = i;
                    while (j > 0 && unsorted[j - 1] > temp)
                    {
                        unsorted[j] = unsorted[j - 1];
                        j--;
                    }
                    unsorted[j] = temp;
                }
            }
        }



        ///<summary>
        ///冒泡排序法
        ///</summary>
        private static void InsertionSort()
        {
            Console.WriteLine("插入排序法");
            int temp = 0;
            int[] arr = { 23, 44, 66, 76, 98, 11, 3, 9, 7 };

            Console.WriteLine("排序前的数组：");
            foreach (int item in arr)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();

            var length = arr.Length;

            for (int i = 1; i < length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (arr[j] > arr[j - 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
                //每次排序后数组
                PrintResult(arr);
            }
            Console.ReadKey();
        }
        ///<summary>
        ///打印结果
        ///</summary>
        ///<paramname="arr"></param>
        private static void PrintResult(IEnumerable<int> arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
        }
    }
}