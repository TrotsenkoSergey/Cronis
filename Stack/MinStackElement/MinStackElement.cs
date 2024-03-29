﻿namespace Stack;

public class MinStackElement
{
    private readonly MyStack<int> _stack;
    private readonly MyStack<int> _stackWithMins;

    public MinStackElement(int stackCapacity)
    {
        _stack = new MyStack<int>(stackCapacity);
        _stackWithMins = new MyStack<int>(stackCapacity);
    }

    public int Size => _stack.Size;

    public void Push(int value)
    {
        if (_stackWithMins.IsEmpty ||
            _stackWithMins.IsNotEmpty && value <= _stackWithMins.Peek())
        {
            _stackWithMins.Push(value);
        }

        _stack.Push(value);
    }

    public int Pop()
    {
        int value = _stack.Pop();

        if (_stackWithMins.IsNotEmpty)
        {
            int minValue = _stackWithMins.Peek();
            if (minValue == value)
            {
                _ = _stackWithMins.Pop();
            }
        }

        return value;
    }

    public int Peek() => _stack.Peek();

    public bool IsEmpty => _stack.IsEmpty;

    public int GetMin()
    {
        if (_stackWithMins.IsEmpty)
        {
            throw new Exception("Stack is empty.");
        }

        return _stackWithMins.Peek();
    }
}
