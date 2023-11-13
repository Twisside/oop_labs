namespace main.c_.uni.laboratory.lab3;

// Abstract Queue Interface
public interface IQueue<T>
{
    void Enqueue(T item);
    T Dequeue();
    T Peek();
    bool IsEmpty();
}
