using Binary;

namespace Test.Binary;

public class NearestDecimalLowerNumberTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Input_equal_expected(int[] input, int[] expected)
    {
        // arrange
        var sut = new NearestDecimalLowerNumber();

        // act
        int[]? output = sut.GetNearestLowerNumber(input);

        // assert
        Assert.NotNull(output);
        Assert.Equal(expected, output);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return new object[][] {
            [3, 1, 2, 0, 8, 4, 8, 6, 6, 1], // input
            [3, 1, 2, 0, 8, 6, 1, 4, 6, 8] // expected
        };
    }
}