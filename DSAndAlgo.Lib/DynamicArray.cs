using System;
namespace DSAndAlgo.Lib
{
    public class DynamicArray<T>
    {
        private int _size;
        private Object[] _array;

        public DynamicArray()
        {
            _size = 0;
            _array = new Object[1];
        }

        public int GetSize()
        {
            return _array.Length;
        }

        public Object Get(int index)
        {
            return (T)_array[index];
        }

        public void Add(T item)
        {
            checkForFit(_size + 1);
            _array[_size++] = item;
        }

        private void checkForFit(int minReqCapacity)
        {
            int oldCapacity = GetSize();
            if(minReqCapacity > oldCapacity)
            {
                int newCapacity = oldCapacity * 2;
                var temp = new Object[newCapacity];
                Array.Copy(_array, temp, _array.Length);
                _array = temp;
            }
        }
    }
}
