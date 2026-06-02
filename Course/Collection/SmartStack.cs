using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class SmartStack<T> : IEnumerable<T>
    {
        private int _currentLength = 0;
        private T[] _stack;

        public int Capacity => _stack.Length;
        public int Count => _currentLength;

        public T this[int index]
        {
            get { if (index >= _currentLength) throw new ArgumentOutOfRangeException("Index is out of range");  return _stack[index]; }
            set { if (index >= _currentLength) throw new ArgumentOutOfRangeException("Index is out of range");  _stack[index] = value;}
        }
        public SmartStack()
        {
            _stack = new T[4];
        }

        public SmartStack(int n)
        {
            _stack = new T[n];
        }

        public SmartStack(IEnumerable<T> stack)
        {
            int length = stack.Count();
            _stack = new T[length];
            var index = length - 1;
            foreach (var item in stack)
            {
                _stack[index--] = item;
            }
            _currentLength = length;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _stack)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private void extendCapacity()
        {
            T[] newStack = new T[Capacity * 2];
            var index = 0;

            foreach (var oldItem in _stack)
            {
                newStack[index++] = oldItem;
            }
            _stack = newStack;
        }

        public void Push(T item)
        {
            if (_currentLength == Capacity)
            {
                extendCapacity();
                Push(item);
            }
            else
            {
                var oldItem = _stack[0];
                T temp;
                _stack[0] = item;
                _currentLength++;
                for (var index = 1; index < _currentLength; index++)
                {
                    temp = _stack[index];
                    _stack[index] = oldItem;
                    oldItem = temp;
                }
            }
        }

        public void PushRange(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Push(item);
            }
        }

        public T Pop()
        {
            if (_currentLength == 0) throw new InvalidOperationException("Stack is empty");
            var result = _stack[0];
            _currentLength--;
            for (var index = 0; index < _currentLength; index++)
            {
                _stack[index] = _stack[index + 1];
            }

            return result;
        }

        public T Peek()
        {
            if (_currentLength == 0) throw new InvalidOperationException("Stack is empty");
            return _stack[0];
        }

        public bool Contains(T value)
        {
            foreach (T item in _stack)
            {
                if (value.Equals(item)) return true;
            }
            return false;
        }
    }
}
