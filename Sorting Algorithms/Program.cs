﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    class Program
    {
        /// <summary>
        /// Comparisons: 1+2+....+n = n(n-1)/2 = O(n^2)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="size"></param>
        public void SelectionSort(int[] arr, int size)
        {
            for(int i = 0; i < size - 1; i++)
            {
                for(int j = i + 1; j < size; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public void Display(int[] arr, int size)
        {
            for(int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arr = { 10, 7, 4, 9, 2 };                       
            
            Program p = new Program();
            Console.WriteLine("Before Sorting: ");
            p.Display(arr, arr.Length);

            p.SelectionSort(arr, arr.Length);
            Console.WriteLine("After Sorting: ");
            p.Display(arr, arr.Length);
            Console.ReadKey();
        }
    }
}
