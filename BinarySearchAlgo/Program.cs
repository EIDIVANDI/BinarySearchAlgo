using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearchAlgoSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 16, 17, 18 };
            Console.WriteLine("The item index is : {0}" , BinarySearchAlgo<int>(arr, 5, 0, arr.GetUpperBound(0)));

            Console.ReadLine();
        }


        static int BinarySearchAlgo<T>(T[] list, T item, int min, int max)
        {
            while (min <= max)
            {
                Comparer<T> comp = Comparer<T>.Default;
                int indexComp = (min + max) / 2;
                if (comp.Compare(item, list[indexComp]) == 0) return indexComp;
                else if (comp.Compare(item, list[indexComp]) < 0) max = --indexComp;
                else min = ++indexComp;
            }
            return 0;
        }
    }
}
