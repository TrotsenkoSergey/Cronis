using Bitoperations;

namespace Test.Bitoperations;

public class MaxSumRangeHandlerTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Input_equal_expected(int[] input, MaxSumRange expected)
    {
        // arrange
        var sut = new MaxSumMatrixRangeHandler();

        // act
        MaxSumRange? output = sut.GetMaxSumRange(input);

        // assert
        Assert.NotNull(output);
        Assert.Equal(expected, output);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return new object[] {
            new int[] { 1, -9, 9, -7, -5 }, // input
            new MaxSumRange(2, 2, 9)  // expected [ 9 ]
        };

        yield return new object[] {
           new int[] { 3, 7, 2, 8, -1 }, // input
            new MaxSumRange(0, 3, 20)  // expected [ 3, 7, 2, 8 ]
        };
    }
}
