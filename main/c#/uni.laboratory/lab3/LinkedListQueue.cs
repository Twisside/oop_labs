namespace main.c_.uni.laboratory.lab3;

public class LinkedListQueue<T> : IQueue<T>
{
    private LinkedList<T> list = new LinkedList<T>();

    public void Enqueue(T item)
    {
        list.AddLast(item);
    }

    public T Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue underflow");

        T item = list.First.Value;
        list.RemoveFirst();
        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue is empty");

        return list.First.Value;
    }

    public bool IsEmpty()
    {
        return list.Count == 0;
    }
}