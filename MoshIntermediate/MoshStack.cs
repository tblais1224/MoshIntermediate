using System;
using System.Collections.Generic;

namespace MoshIntermediate
{
    public class MoshStack
    {
        private readonly List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("You cant add a null object to the stack");
            }

            _list.Add(obj);
        }

        public object Pop()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            object popped = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            return popped;
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}