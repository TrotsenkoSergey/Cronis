using Binary;

namespace Test.Binary;

public class BitsGetHighestTest
{
  [Theory]
  [MemberData(nameof(TestData))]
  public void Input_equal_output(int input, int expected)
  {
    // arrange

    // act
    int output = input.GetHighestBit();

    // assert
    Assert.Equal(expected, output);
  }

  public static IEnumerable<object[]> TestData()
  {
    yield return new object[] {
            1, // input
            0 // expected
        };
    yield return new object[] {
            -1, // input
            1 // expected
        };
    yield return new object[] {
            3, // input
            0 // expected
        };
  }
}
