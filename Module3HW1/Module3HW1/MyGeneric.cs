using System.Collections;

namespace Module3HW1
{
    public class MyGeneric<T> : IMyGeneric<T>, IEnumerable<T>
        where T : IComparable<T>
    {
        private T[] _data;

        public MyGeneric(T[] dataItem)
        {
            _data = dataItem;
        }

        public void Add(T value)
        {
            T[] newData = new T[_data.Length + 1];
            newData[newData.Length - 1] = value;

            for (int i = 0; i < newData.Length - 1; i++)
            {
                newData[i] = _data[i];
            }

            for (int i = newData.Length - 1; i < _data.Length; i++)
            {
                newData[i + 1] = _data[i];
            }

            _data = newData;
        }

        public void AddRange(T[] array)
        {
            int j = 0;
            while (j < array.Length)
            {
                Add(array[j]);
                j++;
            }
        }

        public bool Remove(T item)
        {
            int countElementsToRemove = CountItemInList(item);
            T[] newData = new T[_data.Length - countElementsToRemove];
            int j = 0;
            bool resultOfDelete = false;
            for (int i = 0; i < _data.Length; i++)
            {
                if (_data[i].Equals(item))
                {
                    resultOfDelete = true;
                    Console.WriteLine($"Element {item} removed.");
                    continue;
                }

                newData[j++] = _data[i];
            }

            _data = newData;
            return resultOfDelete;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _data.Length)
            {
                throw new ArgumentOutOfRangeException("no element with that index");
            }
            else
            {
                T[] newData = new T[_data.Length - 1];
                for (int i = 0; i < index; i++)
                {
                    newData[i] = _data[i];
                }

                for (int i = index + 1; i < _data.Length; i++)
                {
                    newData[i - 1] = _data[i];
                }

                _data = newData;
            }
        }

        public void Sort()
        {
            for (int i = 0; i < _data.Length; i++)
            {
                for (int j = 0; j < _data.Length - 1; j++)
                {
                    if (_data[j].CompareTo(_data[j + 1]) > 0)
                    {
                        T temp = _data[j];
                        _data[j] = _data[j + 1];
                        _data[j + 1] = temp;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            int counter = 0;
            foreach (var item in _data)
            {
                yield return item;
            }

            counter++;
        }

        public void PrintArray()
        {
            foreach (var item in _data)
            {
                Console.Write(item + "; ");
            }
        }

        private int CountItemInList(T item)
        {
            int count = 0;
            for (int i = 0; i < _data.Length; i++)
            {
                if (_data[i].Equals(item))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
