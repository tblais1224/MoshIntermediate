using System;
using System.Collections.Generic;

namespace MoshIntermediate
{
    public class Stack
    {
        private List<object> _stack = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("object is null");
            }
            _stack.Add(obj);
        }

        public object Pop()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException("stack is empty");
            }
            else
            {
                object popped = _stack[_stack.Count - 1];
                _stack.RemoveAt(_stack.Count - 1);
                return popped;
            }
        }
        public void Clear()
        {
            _stack.Clear();
        }
    }
}