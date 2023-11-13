namespace main.c_.uni.laboratory.lab3;

public class LinkedListStack<T> : IStack<T>
{
    private LinkedList<T> list = new LinkedList<T>();

    public void Push(T item)
    {
        list.AddLast(item);
    }

    public T Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack underflow");

        T item = list.Last.Value;
        list.RemoveLast();
        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty");

        return list.Last.Value;
    }

    public bool IsEmpty()
    {
        return list.Count == 0;
    }
}
