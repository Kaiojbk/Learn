using System;
using System.Collections.Generic;

namespace SelectSort
{
    class SelectSort
    { 
        public List<int> CreateNumbers(int count)
        {
            Random rd = new Random();
            List<int> list = new List<int>();
            while (list.Count < count)
            {
                list.Add(rd.Next(1, 200));
            }
            return list;
        }


        public void SeleSort(List<int> list,bool isAscending = true)        //Time:O(n^2)   Space:O(1)   不稳定  示例:{5,3,5,2}
        {
            if(isAscending)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Original Data：");
                Print(list);
                Console.ForegroundColor = ConsoleColor.White;
                int min;
                int minIndex;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    min = list[i];
                    minIndex = i;
                    for (int j = i+1; j < list.Count; j++)
                    {
                        if(list[j] < min)
                        {
                            min = list[j];
                            minIndex = j;
                        }
                    }
                    list[minIndex] = list[i];
                    list[i] = min;
                    Console.Write("第{0}次排序：", i);
                    Print(list);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Original Data：");
                Print(list);
                Console.ForegroundColor = ConsoleColor.White;
                int max;
                int maxIndex;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    max = list[i];
                    maxIndex = i;
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        if (list[j] > max)
                        {
                            max = list[j];
                            maxIndex = j;
                        }
                    }
                    list[maxIndex] = list[i];
                    list[i] = max;
                    Console.Write("第{0}次排序：", i);
                    Print(list);
                }
            }
        }

        private void Print(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            SelectSort test = new SelectSort();
            test.SeleSort(test.CreateNumbers(20));
        }
    }
}
