using Binary;

namespace Test.Binary;

public class UniqueElementWithXORTest
{
  [Theory]
  [MemberData(nameof(TestData))]
  public void Input_equal_output(int[] input, int expected)
  {
    // arrange
    var sut = new UniqueElementWithXOR();

    // act
    int output = sut.GetUnique(input);

    // assert
    Assert.Equal(expected, output);
  }

  public static IEnumerable<object[]> TestData()
  {
    yield return new object[] {
            new[] { 2, 7, 2, 4, 4 }, // input
            7 // expected
        };
    yield return new object[] {
            new[] { 67, 235, 43, 235, 67, 43, 99 }, // input
            99 // expected
        };
    yield return new object[] {
            new[] { 0b0101, 0b1100, 0b0101, 0b0011, 0b0011 }, // input
            0b1100 // expected
        };
  }
}
