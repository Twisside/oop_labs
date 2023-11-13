namespace main.c_.uni.laboratory.lab3;

public class DoubleStackQueue<T> : IQueue<T>
{
    private Stack<T> enqueueStack = new Stack<T>();
    private Stack<T> dequeueStack = new Stack<T>();

    public void Enqueue(T item)
    {
        enqueueStack.Push(item);
    }

    public T Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue underflow");

        TransferItems();
        return dequeueStack.Pop();
    }

    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue is empty");

        TransferItems();
        return dequeueStack.Peek();
    }

    public bool IsEmpty()
    {
        return enqueueStack.Count == 0 && dequeueStack.Count == 0;
    }

    private void TransferItems()
    {
        if (dequeueStack.Count == 0)
        {
            while (enqueueStack.Count > 0)
            {
                dequeueStack.Push(enqueueStack.Pop());
            }
        }
    }
}



