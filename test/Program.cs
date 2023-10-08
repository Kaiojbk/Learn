using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

class MergeSort
{
    public List<int> CreateNumbers(int count)
    {
        List<int> list = new List<int>();
        Random rd = new Random();
        while(list.Count < count)
        {
            list.Add(rd.Next(-100,100));
        }
        return list;
    }

    public void MergerSort(List<int> list)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Original Data:");
        Print(list);
        Console.ForegroundColor = ConsoleColor.White;
        List<int> temp = new List<int>(list.Count);
        for (int i = 0; i < temp.Count; i++)
        {
            temp[i] = 0;
        }
        Split(list, temp, 0, temp.Count - 1);
        Console.Write("Last Data:");
        Print(list);
    }
    
    private void Split(List<int> list,List<int> temp,int l,int r)
    {
        
        if (l < r)
        {
            int mid = (l + r) / 2;
            Split(list, temp, l, mid);
            Split(list, temp, mid + 1, r);
            Merge(list, temp, l, mid, r);
        }
    }

    private void Merge(List<int> list,List<int> temp,int l,int mid,int r)
    {
        int tempL = l;
        int tempR = mid + 1;
        int pt = l;

        while (tempL <= mid || tempR <= r)
        {
            if (list[tempL] <= list[tempR])
            {
                temp[pt++] = list[tempL++];
            }
            else
            {
                temp[pt++] = list[tempR++];
            }
        }

        while (tempL <= mid)
        {
            temp[pt++] = list[tempL++];
        }

        while (tempR <= r)
        {
            temp[pt++] = list[tempR++];
        }

        while (l <= r)
        {
            list[l] = temp[l++];
            //l++;
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
        MergeSort test = new MergeSort();
        test.MergerSort(test.CreateNumbers(20));
    }
    
}