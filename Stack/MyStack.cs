namespace Stack;

public class MyStack<T>
{
    private int _capacity;
    private T[] _stack;
    private int _size;
    private int _arrow;
    
    public MyStack(int capacity)
    {
        _capacity = capacity;
        _stack = new T[capacity];
        _size = 0;
        _arrow = -1;
    }

    public int Capacity => _capacity;
    public int Size => _size;
    public bool IsEmpty => _size == 0;
    public bool IsNotEmpty => _size > 0;

    public void Push(T value) 
    { 
        if(_arrow == _capacity - 1) 
        { 
            throw new Exception("Stack overflow");
        }
        
        _arrow++;
        _stack[_arrow] = value;

        _size++;
    }

    public T Pop() 
    {
        if (IsEmpty)
        {
            throw new Exception("Stack is empty");
        }
        
        T value = _stack[_arrow];
        _arrow--;
        
        _size--;

        return value;
    }

    public T Peek() 
    {
        if (IsEmpty)
        {
            throw new Exception("Stack is empty");
        }

        return _stack[_arrow];
    }
}
