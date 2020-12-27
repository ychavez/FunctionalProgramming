using System;
using System.Collections;
using System.Collections.Generic;

namespace MemoryPressure
{
    class Program
    {
        public interface IStack<T> : IEnumerable<T>
        {
            IStack<T> Push(T value);
            IStack<T> Pop();
            T Peek();
            bool IsEmpty { get; }
        }

        public sealed class Stack<T> : IStack<T>
        {
            private sealed class EmptyStack : IStack<T>
            {
                public bool IsEmpty => true;

                public T Peek()
                {
                    throw new Exception("Empty stack");
                }

                public IStack<T> Push(T value)
                {
                    return new Stack<T>(value, this);
                }

                public IStack<T> Pop()
                {
                    throw new Exception("Empty stack");
                }

                public IEnumerator<T> GetEnumerator()
                {
                    yield break;
                }

                IEnumerator IEnumerable.GetEnumerator()
                {
                    return this.GetEnumerator();
                }
            }

            private static readonly EmptyStack empty = new EmptyStack();

            public static IStack<T> Empty => empty;

            private readonly T _head;
            private readonly IStack<T> _tail;

            private Stack(T head, IStack<T> tail)
            {
                _head = head;
                _tail = tail;
            }

            public bool IsEmpty => false;

            public T Peek()
            {
                return _head;
            }

            public IStack<T> Pop()
            {
                return _tail;
            }

            public IStack<T> Push(T value)
            {
                return new Stack<T>(value, this);
            }

            public IEnumerator<T> GetEnumerator()
            {
                for (IStack<T> stack = this; !stack.IsEmpty; stack = stack.Pop())
                    yield return stack.Peek();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }
        }
        static void Main(string[] args)
        {
            IStack<int> stack = Stack<int>.Empty;
            IStack<int> stack1 = stack.Push(10);
            IStack<int> stack2 = stack1.Push(20);
            IStack<int> stack3 = stack2.Push(30);

            foreach (var cur in stack3)
            {
                Console.WriteLine(cur);
            }
            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
