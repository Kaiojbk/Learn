using System;
using System.Collections.Generic;

namespace MergeSort
{
    class MergeSort
    {
        /// <summary>
        /// 随机生成数据
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<int> CreateNumbers(int count)
        {
            List<int> list = new List<int>();
            Random rd = new Random();
            while (list.Count < count)
            {
                list.Add(rd.Next(1, 200));
            }
            return list;
        }

        /// <summary>
        /// 归并排序入口
        /// </summary>
        /// <param name="list"></param>
        /// <param name="isAscending"></param>
        public void mergeSort(List<int> list,bool isAscending = true)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Original Data：");
            Print(list);
            Console.ForegroundColor = ConsoleColor.White;
            List<int> temp = new List<int>(list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                temp.Add(0);
            }
            Split(list, temp, 0, list.Count - 1);
            Console.Write("Sort Results：");
            Print(list);
        }

        private void Merge(List<int> list,List<int> temp,int l,int mid,int r)
        {
            int temp_l = l;
            int temp_r = mid + 1;
            int pt = l;
            while(temp_l<=mid && temp_r <= r)
            {
                if(list[temp_l] <= list[temp_r])
                {
                    temp[pt++] = list[temp_l++];
                }
                else
                {
                    temp[pt++] = list[temp_r++];
                }
            }
            while (temp_l <= mid)
            {
                temp[pt++] = list[temp_l++];
            }
            while (temp_r <= r)
            {
                temp[pt++] = list[temp_r++];
            }
            while (l <= r)
            {
                list[l] = temp[l];
                l++;
            }
        }

        /// <summary>
        /// 拆分数据
        /// </summary>
        /// <param name="list"></param>
        /// <param name="temp"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        private void Split(List<int> list,List<int> temp,int l,int r)
        {
            if(l < r)                               //若能拆分
            {
                int mid = (l + r) / 2;              //找到中间点
                Split(list, temp, l, mid);          //拆分左半区数据
                Split(list, temp, mid + 1, r);      //拆分右半区数据
                Merge(list, temp, l, mid, r);       //合并数据
            }
        }

        /// <summary>
        /// 辅助打印函数
        /// </summary>
        /// <param name="list"></param>
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
            MergeSort test = new MergeSort();
            test.mergeSort(test.CreateNumbers(20));
        }
    }
}
