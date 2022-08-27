using System;
using System.Collections;

namespace Stack_ArrayImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackUsingArray s=new StackUsingArray();
            int[] arr = { 1, 4,2,4, 3, 4, 5 };
            for(int i=0; i<arr.Length; i++)
            {
                s.push(arr[i]);
                Console.WriteLine("size now "+ s.size());
            }
            //while (!s.isEmpty())
            //{
            //    Console.WriteLine(s.pop());
            //}

        }
    }
}
