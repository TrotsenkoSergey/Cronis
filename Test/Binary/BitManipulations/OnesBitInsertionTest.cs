using Binary;

namespace Test.Binary;

public class OnesBitInsertionTest
{
  [Theory]
  [MemberData(nameof(TestData))]
  public void Input_equal_output(Insert obj, byte[] expected)
  {
    // arrange
    var sut = new OnesBitInsertion();

    // act
    byte[] output = sut.CreateArray(obj.Buckets, obj.StartBucket, obj.StartIndex, obj.EndBucket, obj.EndIndex);

    // assert
    Assert.Equal(expected, output);
  }

  public record Insert(int Buckets, int StartBucket, int StartIndex, int EndBucket, int EndIndex);

  public static IEnumerable<object[]> TestData()
  {
    yield return new object[] {
            new Insert(
              Buckets: 4,
              StartBucket: 1,
              StartIndex: 1,
              EndBucket: 3,
              EndIndex: 2), // input
            new byte[] {
                0b0000_0000,
                0b0000_0011,
                0b1111_1111,
                0b1111_1100
              } // expected
        };
    yield return new object[] {
      new Insert(
              Buckets: 4,
              StartBucket: 1,
              StartIndex: 2,
              EndBucket: 1,
              EndIndex: 2), // input
            new byte[] {
                0b0000_0000,
                0b0000_0100,
                0b0000_0000,
                0b0000_0000
              } // expected
        };
  }
}
