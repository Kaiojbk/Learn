using System;
using System.Collections.Generic;

namespace InsertSort
{
    class InsertionSort
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

        public void InserSort(List<int> list,bool isAscending = true)
        {
            if(isAscending)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Original Data：");
                Print(list);
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 1; i < list.Count; i++)
                {
                    int current = list[i];
                    int j = i - 1;
                    while(j >= 0)
                    {
                        if (current < list[j])
                        {
                            list[j + 1] = list[j];
                            j--;
                        }
                        else
                            break;
                    }
                    list[j + 1] = current;
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
                for (int i = 1; i < list.Count; i++)
                {
                    int current = list[i];
                    int j = i - 1;
                    while (j >= 0)
                    {
                        if (current > list[j])
                        {
                            list[j + 1] = list[j];
                            j--;
                        }
                        else
                            break;
                    }
                    list[j + 1] = current;
                    Console.Write("第{0}次排序：", i);
                    Print(list);
                }
            }
        }


        private void Print(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            InsertionSort test = new InsertionSort();
            test.InserSort(test.CreateNumbers(20),false);
        }
    }
}
