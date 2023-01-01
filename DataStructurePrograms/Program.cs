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
        }
    }
}