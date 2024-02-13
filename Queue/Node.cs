namespace Queue;

internal class Node<T>
{
    public T Value { get; init; }
    public Node<T>? Prev {  get; set; }

    public Node(T value)
    {
        Value = value;
    }
}
