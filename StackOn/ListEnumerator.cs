using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOnList
{
    internal class ListEnumerator : IEnumerator
    {
        private List _list;
        private int _index = -1;

        public ListEnumerator(List list) => _list = list;

        public dynamic? Current
        {
            get
            {
                if (_index == -1 || _index > _list.Count) throw new IndexOutOfRangeException();
                return _list[_index];
            }
        }

        object? IEnumerator.Current => Current;

        public bool MoveNext()
        {
            if (_index >= _list.Count - 1) return false;
            _index++;

            return true;
        }
        public void Reset() => _index = -1;
    }
}