using Binary;

namespace Test.Binary;

public class MaxContiniousSequenсeTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Naive_input_equal_expected(int[] input, int expected)
    {
        // arrange
        var sut = new MaxContiniousSequenсe();

        // act
        int output = sut.GetMaxContiniousSequenсeWithNaive(input);

        // assert
        Assert.Equal(expected, output);
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void Sliding_windows_input_equal_expected(int[] input, int expected)
    {
        // arrange
        var sut = new MaxContiniousSequenсe();

        // act
        int output = sut.GetMaxContiniousSequenсeWithSlidingWindow(input);

        // assert
        Assert.Equal(expected, output);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return new object[] {
            new int[] { 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1 }, // input
            6 // expected
        };
        yield return new object[] {
            Array.Empty<int>(), // input
            0 // expected
        };
        yield return new object[] {
            new int[] { 1, 1 }, // input
            2 // expected
        };
    }
}
