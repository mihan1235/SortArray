using System;
using System.Collections.Generic;

namespace SortArray
{
    class Sort
    {
        public static void SortShell(List<int> arr)
        {
            if (arr.Count != 0)
            {
                int range;
                int i_start = 0;
                for (range = arr.Count / 2; range >0; range /= 2)
                {
                    while (i_start + range < arr.Count)
                    {
                        for (int i = i_start; i < arr.Count; i += range)
                        {
                            int pos2 = i + range;
                            if (pos2 < arr.Count)
                            {
                                if (arr[i] > arr[pos2]) change_elem(i, pos2, arr);
                            }
                        }

                        i_start++;
                    }
                    i_start = 0;
                    if (range == 1) break;
                }

            }
        }

        static void change_elem(int pos1, int pos2, List<int> arr)
        {
            if (((pos1 > 0) && (pos1 < arr.Count)) || ((pos2 > 0) && (pos2 < arr.Count)))
            {
                int tmp = arr[pos1];
                arr[pos1] = arr[pos2];
                arr[pos2] = tmp;
            }
        }
    }

    class Program
    {
        static void print_list(List<int> arr)
        {
            int i = 0;
            foreach (var el in arr)
            {
                Console.WriteLine($"i: [{i++}] elem: [{el}]");
            }
        }
        static void Main(string[] args)
        {

            List<int> arr = new List<int>(10);
            arr.Add(23);
            arr.Add(13);
            arr.Add(-23);
            arr.Add(233);
            arr.Add(243);
            arr.Add(3);
            arr.Add(73);
            arr.Add(28);
            arr.Add(24);
            arr.Add(12);

            print_list(arr);
            Sort.SortShell(arr);

            Console.WriteLine("Sorted: ");
            print_list(arr);
        }
    }
}
