using Binary;

namespace Test.Binary;

public class MaxContiniousSequenсeWithAddingTest
{
  [Theory]
  [MemberData(nameof(TestData))]
  public void My_input_equal_expected(int[] input, int expected)
  {
    // arrange
    var sut = new MaxContiniousSequenсeWithAdding();

    // act
    int output = sut.GetMaxContiniousSequenсeWithAddingMy(input);

    // assert
    Assert.Equal(expected, output);
  }

  [Theory]
  [MemberData(nameof(TestData))]
  public void Cronis_input_equal_expected(int[] input, int expected)
  {
    // arrange
    var sut = new MaxContiniousSequenсeWithAdding();

    // act
    int output = sut.GetMaxContiniousSequenсeWithAddingCronis(input);

    // assert
    Assert.Equal(expected, output);
  }

  public static IEnumerable<object[]> TestData()
  {
    yield return new object[] {
            new int[] { 0, 0, 0, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1, 1, 1, 0, 0, 1 }, // input
            6 // expected
        };
    yield return new object[] {
            Array.Empty<int>(), // input
            0 // expected
        };
    yield return new object[] {
            new int[] { 1, 1 }, // input
            2 // expected
        };
    yield return new object[] {
            new int[] { 0, 1, 1 }, // input
            3 // expected
        };
    yield return new object[] {
            new int[] { 1, 1, 0 }, // input
            3 // expected
        };
  }
}