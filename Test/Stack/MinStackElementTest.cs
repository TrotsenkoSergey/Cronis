using Stack;

namespace Test.Stack;

public class MinStackElementTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Expected_min_value_equal_output(int stackSize, int[] input, int expected)
    {
        // arrange
        var sut = new MinStackElement(stackSize);
        foreach (int i in input)
        {
            sut.Push(i);
        }

        // act
        _ = sut.Pop();
        var output = sut.GetMin();

        // assert
        Assert.Equal(expected, output);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return new object[] {
            6, // stackSize
            new int[] { 5, 3, 7, 6, 8, 3 }, // input
            3 // expected
        };
        yield return new object[] {
            6, // stackSize
            new int[] { 5, 4, 7, 6, 8, 3 }, // input
            4 // expected
        };
        yield return new object[] {
            6, // stackSize
            new int[] { 11, 2, 7, 9, 33, 9 }, // input
            2 // expected
        };
    }
}
