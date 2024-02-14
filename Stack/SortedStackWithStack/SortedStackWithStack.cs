namespace Stack;

public class SortedStackWithStack
{
    public MyStack<int> Sort(MyStack<int> stack)
    {
        var sortedStack = new MyStack<int>(stack.Size);

        while (stack.IsNotEmpty)
        {
            int value = stack.Pop();

            while (sortedStack.IsNotEmpty && value > sortedStack.Peek())
            {
                int sortedValue = sortedStack.Pop();
                stack.Push(sortedValue);
            }

            sortedStack.Push(value);
        }

        return sortedStack;
    }
}
