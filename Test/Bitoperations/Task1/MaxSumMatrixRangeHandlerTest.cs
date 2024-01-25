using Bitoperations;

namespace Test.Bitoperations;

public class MaxSumMatrixRangeHandlerTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Input_equal_expected(int[][] input, MaxSumMatrixRange expected)
    {
        // arrange
        var sut = new MaxSumMatrixRangeHandler();

        // act
        MaxSumMatrixRange? output = sut.GetMaxSumMatrixRange(input);

        // assert
        Assert.NotNull(output);
        Assert.Equal(expected, output);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return new object[] {
            new int[][] {
                [ 1, -9, 9, -7, -5 ],
                [ 3, 7, 2, 8, -1 ],
                [ -3, -7, 1, 1, 1 ],
                [ 1, -4, -5, 9, 9],
                [1, 2, 2, -9, 1]
            }, // input
            new MaxSumMatrixRange(StartRow: 1,
                                  StartCol: 3,
                                  EndRow: 3,
                                  EndCol: 4,
                                  Sum: 27)  // expected
        };

    }
}
