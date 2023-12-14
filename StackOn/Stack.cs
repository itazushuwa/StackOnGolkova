using StackOn.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StackOnList
{
    class Stack<T> : IEnumerable where T : struct, IComparable
    {
        private int _size;
        private List _list;
        public int Count => _list.Count;
        //private int _currentSum;
        //public double AvgValue { get; private set; }
        public Stack(int size)
        {
            try
            {
                _list = new List();
                if (_size is <= 0)
                {
                    throw new ContainerCapacityException("Размер хранилища не может быть <= 0");
                }
                _size = size;
            }
            catch (ContainerCapacityException e)
            {
                Console.WriteLine(e.Message);
                _size = 10;
            }
        }
        public void Push(T item)
        {
            if (Count == _size)
            {
                throw new ContainerOverflowException("Стэк полон");
            }
            if (item is <= -500 || item is >= 500)
            {
                throw new ItemValueException("Допустимый диапазон значение каждого элемента (-500;500)");
            }
            else
            {
                //Count++;
                //IncreaseAvgValue(item);
                _list.Add(item);
            }
        }

        public T Pop()
        {
            if (Count == 0) throw new ContainerUnderflowException("Стэк пуст");
            //DecreaseAvgValue(Peek());
            //Count--;
            return _list.Remove();
        }

        public T Peek()
        {
            if (Count == 0) throw new ContainerUnderflowException("Стэк пуст");
            //var cache = _list.Remove();
            //_list.Add(cache);
            return _list.Head!.Data;
        }
        public T Find(T item)
        {
            if (Count == 0) throw new ContainerUnderflowException("Стэк пуст");
            foreach (T t in this)
            {
                if (t.Equals(item)) return t;
            }
            return default;
        }

        public T this[int index]
        {
            get => _list[index];
            set => _list[index] = value;
        }
        public IEnumerator GetEnumerator() => new ListEnumerator(_list);

        public void Sort()
        {
            for (int i = 0; i < Count; ++i)
            {
                for (int j = 0; j < Count - 1 - i; j++)
                {
                    if (this[j].CompareTo(this[j + 1]) > 0)
                    {
                        (this[j], this[j + 1]) = (this[j = 1], this[j]);
                    }
                }
            }
        }

        //private void IncreaseAvgValue(int item)
        //{
        //    _currentSum += item;
        //    AvgValue = _currentSum;
        //    AvgValue /= Count;
        //}

        //private void DecreaseAvgValue(int item)
        //{
        //    _currentSum -= item;
        //    AvgValue = _currentSum;
        //    if (Count == 0)
        //    {
        //        AvgValue = 0;
        //        return;
        //    }
        //    AvgValue /= Count;
        //}

        public override string ToString()
        {
            var current = _list.Head;
            var output = string.Empty;
            for (int i = 0; i < _list.Count; i++)
            {
                output += current.Data + " ";
                current = current.Next;
            }
            return output;
        }
    }
}

//public Stack(Stack current)
//{
//    _list = new List<int>();
//    _size = current._size;
//    Count = current.Count;
//    _list.Count = current._list.Count;
//    if (current.Count == 0)
//    {
//        return;
//    }
//    Node<int> originalHead = current._list.Head;
//    Node<int> newNode = new Node<int>(originalHead.Data);
//    _list.Head = newNode;
//    Node<int> tempHead = _list.Head;
//    originalHead = originalHead.Next;
//    while (originalHead != null)
//    {
//        newNode = new Node<int>(originalHead.Data);
//        tempHead.Next = newNode;
//        originalHead = originalHead.Next;
//        tempHead = tempHead.Next;
//    }
//}