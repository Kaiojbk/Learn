using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>() { 5, 2, 9, 1, 3, 6 };
        MergeSort(list);
        Console.WriteLine(string.Join(", ", list));
    }

    static void MergeSort(List<int> list)
    {
        List<int> temp = new List<int>(list.Count);
        for (int i = 0; i < list.Count; i++)
        {
            temp.Add(0);  // 创建临时列表
        }
        Split(list, temp, 0, list.Count - 1);
    }

    static void Split(List<int> list, List<int> temp, int l, int r)
    {
        if (l < r)
        {
            int mid = (l + r) / 2;
            Split(list, temp, l, mid);
            Split(list, temp, mid + 1, r);
            Merge(list, temp, l, mid, r);
        }
    }

    static void Merge(List<int> list, List<int> temp, int l, int mid, int r)
    {
        int leftStart = l;
        int rightStart = mid + 1;
        int tempIndex = l;

        while (leftStart <= mid && rightStart <= r)
        {
            if (list[leftStart] <= list[rightStart])
            {
                temp[tempIndex] = list[leftStart];
                leftStart++;
            }
            else
            {
                temp[tempIndex] = list[rightStart];
                rightStart++;
            }
            tempIndex++;
        }

        while (leftStart <= mid)
        {
            temp[tempIndex] = list[leftStart];
            leftStart++;
            tempIndex++;
        }

        while (rightStart <= r)
        {
            temp[tempIndex] = list[rightStart];
            rightStart++;
            tempIndex++;
        }

        for (int i = l; i <= r; i++)
        {
            list[i] = temp[i];
        }
    }
}