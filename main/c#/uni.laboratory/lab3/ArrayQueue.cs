namespace main.c_.uni.laboratory.lab3;

public class ArrayQueue<T> : IQueue<T>
{
    private T[] items;
    private int front;
    private int rear;

    public ArrayQueue(int capacity)
    {
        items = new T[capacity];
        front = 0;
        rear = -1;
    }

    public void Enqueue(T item)
    {
        if (rear == items.Length - 1)
            throw new InvalidOperationException("Queue overflow");

        items[++rear] = item;
    }

    public T Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue underflow");

        T item = items[front++];
        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue is empty");

        return items[front];
    }

    public bool IsEmpty()
    {
        return front > rear;
    }
}