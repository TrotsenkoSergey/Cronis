using Binary;

namespace Test.Binary;

public class SwapWithXORTest
{
  [Theory]
  [MemberData(nameof(TestIntData))]
  public void Input_Int_equal_output(Tuple<int, int> input, Tuple<int, int> expected)
  {
    // arrange
    var sut = new SwapWithXOR();

    // act
    var output = sut.Elements(input.Item1, input.Item2);

    // assert
    Assert.Equal(expected.Item1, output.a);
    Assert.Equal(expected.Item2, output.b);
  }

  [Theory]
  [MemberData(nameof(TestCharData))]
  public void Input_Char_equal_output(Tuple<char, char> input, Tuple<char, char> expected)
  {
    // arrange
    var sut = new SwapWithXOR();

    // act
    var output = sut.Elements(input.Item1, input.Item2);

    // assert
    Assert.Equal(expected.Item1, output.a);
    Assert.Equal(expected.Item2, output.b);
  }

  public static IEnumerable<object[]> TestIntData()
  {
    yield return new object[] {
            Tuple.Create(5,6), // input
            Tuple.Create(6,5) // expected
        };
    yield return new object[] {
            Tuple.Create(0b0011, 0b1100), // input
            Tuple.Create(0b1100, 0b0011) // expected
        };
  }

  public static IEnumerable<object[]> TestCharData()
  {
    yield return new object[] {
      Tuple.Create('X','Y'), // input
      Tuple.Create('Y','X') // expected
    };
  }
}
