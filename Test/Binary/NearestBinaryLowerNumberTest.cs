using Binary;

namespace Test.Binary;

public class NearestBinaryLowerNumberTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Input_equal_expected(int[] input, int[] expected)
    {
        // arrange
        var sut = new NearestBinaryLowerNumber();

        // act
        int[]? output = sut.GetNearestLowerNumber(input);

        // assert
        Assert.NotNull(output);
        Assert.Equal(expected, output);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return new object[][] {
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 1, 1, 0, 0], // input
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1] // expected
        };
    }
}
