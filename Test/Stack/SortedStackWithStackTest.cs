using Stack;

namespace Test.Stack;

public class SortedStackWithStackTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Expected_output_equal_actual(int stackSize, int[] input, int[] expected)
    {
        // arrange
        var sut = new SortedStackWithStack();
        var stack = new MyStack<int>(stackSize);
        foreach (int i in input)
        {
            stack.Push(i);
        }

        // act
        var sortedStack = sut.Sort(stack);

        // assert
        List<int> output = new();
        while (!sortedStack.IsEmpty)
        {
            output.Add(sortedStack.Pop());
        }

        Assert.Equal(expected, output);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return new object[] {
            6, // stackSize
            new int[] { 5, 3, 7, 6, 8, 3 }, // input
            new int[] { 3, 3, 5, 6, 7, 8 } // expected
        };
        yield return new object[] {
            6, // stackSize
            new int[] { 5, 4, 7, 6, 8, 3 }, // input
            new int[] { 3, 4, 5, 6, 7, 8 } // expected
        };
        yield return new object[] {
            6, // stackSize
            new int[] { 11, 2, 7, 9, 33, 9 }, // input
            new int[] { 2, 7, 9, 9, 11, 33 } // expected
        };
    }
}
