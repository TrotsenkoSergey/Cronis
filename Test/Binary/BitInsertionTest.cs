using Binary;

namespace Test.Binary;

public class BitInsertionTest
{
  [Theory]
  [MemberData(nameof(TestData))]
  public void Input_equal_output(Insert obj, int expected)
  {
    // arrange
    var sut = new BitInsertion();

    // act
    int output = sut.InsertAtRange(obj.Main, obj.Insertion, obj.StartRange, obj.EndRange);

    // assert
    Assert.Equal(expected, output);
  }

  public record Insert(int Main, int Insertion, int StartRange, int EndRange);

  public static IEnumerable<object[]> TestData()
  {
    yield return new object[] {
            /*
            34 - 0...0010 0010
            28 - 0...0001 1100
            start - 2, end - 4
            output - 62 - 0...0011 1110
            */
            new Insert(34, 28, 2, 4), // input
            62 // expected
        };
    yield return new object[] {
      new Insert(5123, 0, 0, 1), // input
      5120 // expected
    };
  }
}
