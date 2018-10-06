using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_17._6._1
{
    class MyStack<T>
    {
        private T[] StackArray;
        private int StackPointer = 0;

        public void Push(T x)
        {
            if (!IsStackFull)
                StackArray[StackPointer++] = x;
        }

        public T Pop()
        {
            return (!IsStackEmpty)
                ? StackArray[--StackPointer]
                : StackArray[0];
        }

        private const int MaxStack = 10;
        private bool IsStackFull
        {
            get { return StackPointer >= MaxStack; }
        }

        private bool IsStackEmpty
        {
            get { return StackPointer <= 0; }
        }

        public void Print()
        {
            for(int i = StackPointer; i >=0; i--)
                Console.WriteLine("Value:{0}", StackArray[i]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> StackInt = new MyStack<int>();
            MyStack<string> StackString = new MyStack<string>();

            StackInt.Push(3);
            StackInt.Push(5);
            StackInt.Push(7);
            StackInt.Push(9);
            StackInt.Print();

            StackString.Push("This is fun");
            StackString.Push("Hi there!");
            StackString.Print();
        }
    }
}
