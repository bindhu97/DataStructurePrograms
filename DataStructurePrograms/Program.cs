using DataStructurePrograms;
using System;
using System.Collections.Generic;

namespace Data_Structure_Problems
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            string text = "Search Happiness in everything";
            string[] list = text.Split(" ");
            int count = 0;
            while (count < list.Length)
            {
                linkedList.Add(list[count++]);
            }
            linkedList.Display();
            Console.WriteLine("\n");
            linkedList.Search("Happiness");

            LinkedList<int> linkedList1 = new LinkedList<int>();
            int[] number = { 65, 1, 79, 2, 35, 2, 42 };
            int[] list1 = number;
            Array.Sort(list1);
            int count1 = 0;
            while (count1 < list1.Length)
            {
                linkedList1.Add(list1[count1++]);
            }
            Console.WriteLine("\n");
            linkedList1.Display();
            linkedList1.Search(79);
        }
    }
}