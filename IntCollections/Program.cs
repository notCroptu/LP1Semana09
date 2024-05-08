using System;
using System.Collections.Generic;

namespace IntCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();
            HashSet<int> hashSet = new HashSet<int>();

            int[] arr = new int[5] {1, 10, -30, 10, -5};

            foreach (int i in arr)
            {
                list.Add(i);
                stack.Push(i);
                queue.Enqueue(i);
                hashSet.Add(i);
            }
            
            string s = "List:";
            foreach (int i in list)
            {
                s += $" {i},";
            }
            Console.WriteLine(s.Remove(s.Length - 1));

            s = "Stack:";
            foreach (int i in stack)
            {
                s += $" {i},";
            }
            Console.WriteLine(s.Remove(s.Length - 1));

            s = "Queue:";
            foreach (int i in queue)
            {
                s += $" {i},";
            }
            Console.WriteLine(s.Remove(s.Length - 1));

            s = "HashSet:";
            foreach (int i in hashSet)
            {
                s += $" {i},";
            };
            Console.WriteLine(s.Remove(s.Length - 1));
        }
    }
}
