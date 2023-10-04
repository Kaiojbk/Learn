using System;
using System.Collections.Generic;

namespace Sort
{
    class BubbleSort
    {
        public List<int> CreateNumbers(int numbers)
        {
            List<int> list = new List<int>();
            Random rd = new Random();
            while (list.Count < numbers)
            {
                list.Add(rd.Next(1, 200));
            }
            return list;
        }

        public void BubbSort(List<int> list, bool isDescending = true)      // Time:O(n^2)  Space:O(1)  稳定 
        {
            bool Change;
            int lastChangeIndex = 0;
            int sortLastIndex = list.Count - 1;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Original Data:");
            Print(list);
            Console.ForegroundColor = ConsoleColor.White;
            if (isDescending)         //升序
            {
                for (int i = 0; i < list.Count - 2; i++)
                {
                    Change = false;
                    for (int j = 0; j < sortLastIndex; j++)
                    {
                        if (list[j] > list[j + 1])
                        {
                            Change = true;
                            lastChangeIndex = j;
                            list[j] += list[j + 1];
                            list[j + 1] = list[j] - list[j + 1];
                            list[j] = list[j] - list[j + 1];
                        }
                    }
                    sortLastIndex = lastChangeIndex;

                    if (Change is false)
                    {
                        return;
                    }
                    Console.Write("第{0}次排序：", i + 1);
                    Print(list);
                }
            }
            else
            {
                for (int i = 0; i < list.Count - 2; i++)
                {
                    Change = false;
                    for (int j = 0; j < sortLastIndex; j++)
                    {
                        if (list[j] < list[j + 1])
                        {
                            Change = true;
                            lastChangeIndex = j;
                            list[j] += list[j + 1];
                            list[j + 1] = list[j] - list[j + 1];
                            list[j] = list[j] - list[j + 1];
                        }
                    }
                    sortLastIndex = lastChangeIndex;

                    if (Change is false)
                    {
                        return;
                    }
                    Console.Write("第{0}次排序：", i + 1);
                    Print(list);
                }
            }
        }

        void Print(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

    class TestBubbSort
    {
        static void Main(string[] args)
        {
            BubbleSort testBubbSort = new BubbleSort();
            testBubbSort.BubbSort(testBubbSort.CreateNumbers(20));
        }
    }


}

