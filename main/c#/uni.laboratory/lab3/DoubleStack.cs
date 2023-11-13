namespace main.c_.uni.laboratory.lab3;

public class DoubleStack<T> : IStack<T>
{
    private Stack<T> primaryStack = new Stack<T>();
    private Stack<T> auxiliaryStack = new Stack<T>();

    public void Push(T item)
    {
        primaryStack.Push(item);
    }

    public T Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack underflow");

        TransferItems();
        return auxiliaryStack.Pop();
    }

    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty");

        TransferItems();
        return auxiliaryStack.Peek();
    }

    public bool IsEmpty()
    {
        return primaryStack.Count == 0 && auxiliaryStack.Count == 0;
    }

    private void TransferItems()
    {
        if (auxiliaryStack.Count == 0)
        {
            while (primaryStack.Count > 0)
            {
                auxiliaryStack.Push(primaryStack.Pop());
            }
        }
    }
}