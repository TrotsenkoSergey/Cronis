namespace Stack;

public class MyStack<T>
{
    private const int DefaultStackSize = 3;
    private int _stackSize;
    private int _stackArrow = -1;
    private T[] _stack;
    
    public MyStack(int stackSize = DefaultStackSize)
    {
        _stackSize = stackSize;
        _stack = new T[_stackSize];
    }

    public int Size => _stackSize;
    public bool IsEmpty => _stackArrow == -1;

    public void Push(T value) 
    { 
        if(_stackArrow == _stackSize - 1) 
        { 
            throw new Exception("Stack overflow");
        }
        
        _stackArrow++;
        _stack[_stackArrow] = value;
        
        _stackSize++;
    }

    public T Pop() 
    {
        if (IsEmpty)
        {
            throw new Exception("Stack is empty");
        }
        
        T value = _stack[_stackArrow];
        _stackArrow--;
        
        _stackSize--;

        return value;
    }


    public T Peek() 
    {
        if (IsEmpty)
        {
            throw new Exception("Stack is empty");
        }

        return _stack[_stackArrow];
    }
}
