using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate
{
    public class Stack<T>
    {
        private List<T> _stack = new List<T>();
        public int Count => _stack.Count;

        public void Push(T obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("obj");
            }
            _stack.Add(obj);
        }

        public T Pop()
{
            if (IsEmpty())
            {
                throw new InvalidOperationException("stack is empty");
            }
            T obj = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1);
            return obj;
        }

        public void Clear()
        {
            _stack.Clear();
        }

        public bool IsEmpty()
        {
            return _stack.Count == 0;
        }
    }
}
