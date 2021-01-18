using System;
using System.Collections.Generic;
using System.Text;

namespace FiskBank.Modules
{
    public class GenericList<T>
    {
        private T[] _list;
        private int _position;
        public int Length
        {
            get
            {
                return _position;
            }
        }

        public GenericList(int length = 2)
        {
            _list = new T[length];
        }

        public T this[int i]
        {
            get
            {
                return GetItem(i);
            }
        }

        private T GetItem(int i)
        {
            if (i < 0) throw new ArgumentException();
            if (i > _position) throw new ArgumentOutOfRangeException();
            return _list[i];
        }

        public void RemoveItem(T obj)
        {
            int position = 0;

            for (int i = 0; i < _position; i++)
            {
                if (obj.Equals(_list[i]))
                {
                    position = i;
                    break;
                }
            }

            for (int i = position; i < _position - 1; i++)
            {
                _list[i] = _list[i + 1];
            }

            _position--;
        }

        public void AddVariousItems(params T[] items)
        {
            foreach(T item in items)
            {
                AddItem(item);
            }
        }

        public void AddItem(T item)
        {
            VerifyArrayCapacity(_position + 1);
            _list[_position] = item;
            _position++;
        }

        private void VerifyArrayCapacity(int length)
        {
            if (_list.Length >= length) return;

            T[] listExpanded = new T[length * 2];
            
            for (int i = 0; i < _list.Length; i++)
            {
                listExpanded[i] = _list[i];
            }
            _list = listExpanded;
        }
    }
}
