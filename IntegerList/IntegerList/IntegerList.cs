using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerList
{
    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private int maxSize;
        private int size;

        public IntegerList()
        {
            maxSize = 4;
            _internalStorage = new int[maxSize];
            size = 0;
        }

        public IntegerList(int initialSize)
        {
            if (initialSize > 0)
            {
                maxSize = initialSize;
                _internalStorage = new int[maxSize];
                size = 0;
            }
            else
                Console.WriteLine("Velicina mora biti pozitivna!");
        }

        public void Add(int item)
        {
            if (size == maxSize)
            {
                maxSize *= 2;
                int[] temp = new int[maxSize];
                for (int i = 0; i < size; i++)
                    temp[i] = _internalStorage[i];
                _internalStorage = temp;
            }
            _internalStorage[size] = item;
            size++;
        }

        public bool Remove(int item)
        {
            int index = size;
            for (int i = 0; i < size; i++)
                if (_internalStorage[i] == item)
                {
                    index = i;
                    break;
                }
            return RemoveAt(index);
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= size)
                return false;
            if (index != size - 1)
                for (int i = index; i < size - 1; i++)
                    _internalStorage[i] = _internalStorage[i + 1];
            size--;
            return true;
        }

        public int GetElement(int index)
        {
            if (index >= 0 && index < size)
                return _internalStorage[index];
            else
                throw new IndexOutOfRangeException();
        }

        public int IndexOf(int item)
        {
            int index = -1;
            for (int i = 0; i < size; i++)
                if (_internalStorage[i] == item)
                {
                    index = i;
                    break;
                }
            return index;
        }

        public int Count { get { return size; } }

        public void Clear()
        {
            size = 0;
        }

        public bool Contains(int item)
        {
            bool contains = false;
            for (int i = 0; i < size; i++)
                if (_internalStorage[i] == item)
                {
                    contains = true;
                    break;
                }
            return contains;
        }
    }
}
