using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_ArrayImplementation
{
    public  class StackUsingArray //        IMPLEMENTED THIS ONLY FOR THE DATA TYPE OF INT
                                  //        CHANGING CLASS TO StackUsingArray<T> AND CONVERTING DATA TYPE FROM INT TO GENERIC WOULD MAKE STACK DYNAMIC
    {
        private int[] data;
        private int topIndex;
        public StackUsingArray()
        {
            data=new int[10];
            topIndex = -1;
        }
        public StackUsingArray(int size)    // USER CAN DECIDE THE SIZE OF THE STACK
        {
            data = new int[size];
            topIndex = -1;
        }


        public void push(int elem) //O(1)
        {
            if(topIndex == data.Length - 1)
            {
                DoubleCapacity();
            }
            else
            {
                data[++topIndex] = elem;
            }

        }

        private void DoubleCapacity()
        {
            int[] temp = data;
            data = new int[2*temp.Length];
            for(int i = 0; i < temp.Length; i++)
            {
                data[i] = temp[i];
            }
        }

        public int top() //O(1)
        {
            if (topIndex == -1)
            {
                throw new StackEmptyException();
            }
            return data[topIndex];
        }
        public int pop() //O(1)
        {
            if (topIndex == -1)
            {
                throw new StackEmptyException();
            }
            int temp=data[topIndex--];
            return temp;
        }
        public int size() //O(1)
        {
            return topIndex+1;
        }
        public bool isEmpty() //O(1)
        {
            return topIndex == -1;   
        }
    }
}
