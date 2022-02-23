namespace Module3HW1
{
    public interface IMyGeneric<T>
    {
        void Add(T item);
        void AddRange(T[] array);
        bool Remove(T item);
        void RemoveAt(int index);
        void Sort();
    }
}
