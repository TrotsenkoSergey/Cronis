using Binary.Bin;

namespace Test.Binary;

public class MaxContiniousSequenceWithAdditionalOneBinTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Input_equal_expected(int input, int expected)
    {
        // arrange
        var sut = new MaxContiniousSequenсeWithAdditionalOne();

        // act
        int output = sut.GetMaxSubSetSizeWithAdditionalOne(input);

        // assert
        Assert.Equal(expected, output);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return new object[] {
            32, // input
            2 // expected
        };
        yield return new object[] {
            3780567, // input
            8 // expected
        };
        yield return new object[] {
            0, // input
            1 // expected
        };
        yield return new object[] {
            ~0, // input
            32 // expected
        };
    }
}