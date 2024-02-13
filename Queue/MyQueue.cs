namespace Queue;

public class MyQueue<T>
{
    private Node<T>? _head;
    private Node<T>? _tail;
    private int _size = 0;

    public int Size => _size;
    public bool IsEmpty => _head == null;

    public void Enqueue(T value)
    {
        Node<T> newNode = new(value);
        
        if (_tail != null)
        {
            _tail.Prev = newNode;
        }

        _tail = newNode;

        if (IsEmpty)
        {
            _head = _tail;
        }

        _size++;
    }

    public T Dequeue()
    {
        if (IsEmpty)
        {
            throw new Exception("Queue is empty");
        }
        
        T value = _head!.Value;
        _head = _head.Prev; 

        if (IsEmpty) // check another - new head
        {
            _tail = null;
        }

        _size--;

        return value;
    }

    public T Peek() 
    {
        if (IsEmpty)
        {
            throw new Exception("Queue is empty");
        }

        return _head!.Value;
    }
}
