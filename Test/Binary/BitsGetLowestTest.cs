using Binary;

namespace Test.Binary;

public class BitsGetLowestTest
{
  [Theory]
  [MemberData(nameof(TestData))]
  public void Input_equal_output(int input, int expected)
  {
    // arrange

    // act
    int output = input.GetLowestBit();

    // assert
    Assert.Equal(expected, output);
  }

  public static IEnumerable<object[]> TestData()
  {
    yield return new object[] {
            0b0001, // input 1
            1 // expected
        };
    yield return new object[] {
            0b0010, // input 2
            0 // expected
        };
    yield return new object[] {
            0b0001_0011, // input 19
            1 // expected
        };
  }
}
