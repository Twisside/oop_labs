namespace main.c_.uni.laboratory.lab3;

// Abstract Stack Interface
public interface IStack<T>
{
    void Push(T item);
    T Pop();
    T Peek();
    bool IsEmpty();
}