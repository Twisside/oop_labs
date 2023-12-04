namespace main.c_.uni.laboratory.lab3;

public class Lab3
{
    private static void Main3(String[] args)
    {
         // Testing Stack Implementations
        Console.WriteLine("Stack Implementations:");
        Console.WriteLine("===============");

        // ArrayStack
        IStack<int> arrayStack = new LinkedListStack<int>();
        arrayStack.Push(1);
        arrayStack.Push(2);
        arrayStack.Push(2);
        Console.WriteLine("ArrayStack:");
        Console.WriteLine("Pop: " + arrayStack.Pop()); // Output: 2
        Console.WriteLine("Peek: " + arrayStack.Peek()); // Output: 2
        Console.WriteLine("Pop: " + arrayStack.Pop()); // Output: 2
        Console.WriteLine("Pop: " + arrayStack.Pop()); // Output: 1
       // Console.WriteLine("Peek: " +?= arrayStack.Peek()); // Output: Stack is empty

        // LinkedListStack
        IStack<string> linkedListStack = new LinkedListStack<string>();
        linkedListStack.Push("Hello");
        linkedListStack.Push("World");
        Console.WriteLine("\nLinkedListStack:");
        Console.WriteLine("Pop: " + linkedListStack.Pop()); // Output: World
        Console.WriteLine("Peek: " + linkedListStack.Peek()); // Output: Hello

        // DoubleStack
        IStack<double> doubleStack = new DoubleStack<double>();
        doubleStack.Push(3.14);
        doubleStack.Push(2.71);
        Console.WriteLine("\nDoubleStack:");
        Console.WriteLine("Pop: " + doubleStack.Pop()); // Output: 2.71
        Console.WriteLine("Peek: " + doubleStack.Peek()); // Output: 3.14

        // Testing Queue Implementations
        Console.WriteLine("\nQueue Implementations:");
        Console.WriteLine("===============");

        // ArrayQueue
        IQueue<int> arrayQueue = new LinkedListQueue<int>();
        arrayQueue.Enqueue(10);
        arrayQueue.Enqueue(20);
        Console.WriteLine("ArrayQueue:");
        Console.WriteLine("Peek: " + arrayQueue.Peek()); // Output: 10

        Console.WriteLine("Dequeue: " + arrayQueue.Dequeue()); // Output: 10
        Console.WriteLine("Peek: " + arrayQueue.Peek()); // Output: 20

        // LinkedListQueue
        IQueue<string> linkedListQueue = new LinkedListQueue<string>();
        linkedListQueue.Enqueue("Will kill");
        linkedListQueue.Enqueue("Someone");
        Console.WriteLine("\nLinkedListQueue:");
        Console.WriteLine("Dequeue: " + linkedListQueue.Dequeue()); // Output: OpenAI
        Console.WriteLine("Peek: " + linkedListQueue.Peek()); // Output: GPT

        // DoubleStackQueue
        IQueue<bool> doubleStackQueue = new DoubleStackQueue<bool>();
        doubleStackQueue.Enqueue(true);
        doubleStackQueue.Enqueue(false);
        Console.WriteLine("\nDoubleStackQueue:");
        Console.WriteLine("Dequeue: " + doubleStackQueue.Dequeue()); // Output: true
        Console.WriteLine("Peek: " + doubleStackQueue.Peek()); // Output: false
    }
}