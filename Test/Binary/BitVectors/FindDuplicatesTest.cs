using Binary.BitVectors;

namespace Test.Binary;

public class FindDuplicatesTest
{
  [Theory]
  [MemberData(nameof(TestData))]
  public void Inputs_is_not_throw_exception(Input input, List<int> expected)
  {
    //arrange
    var sut = new FindDuplicates();

    //act
    Func<Input, List<int>> action = (input) =>
      sut.Find(input.Arr, input.MaxIntInArr, input.MaxMemorySizeInKiB);

    //assert
    Assert.IsAssignableFrom<List<int>>(action(input));
  }

  [Theory]
  [MemberData(nameof(TestData))]
  public void Output_equal_expected(Input input, List<int> expected)
  {
    //arrange
    var sut = new FindDuplicates();

    //act
    var output = sut.Find(input.Arr, input.MaxIntInArr, input.MaxMemorySizeInKiB);

    //assert
    Assert.Equal(expected, output);
  }

  public record Input(int[] Arr, int MaxIntInArr, int MaxMemorySizeInKiB);

  public static IEnumerable<object[]> TestData()
  {
    yield return new object[] {
            new Input([1,2,2,1,3], 32000, 4), // input
            new List<int> { 2, 1 } // expected
        };
    yield return new object[] {
            new Input([7,2234,2352,1,2352, 1, 437, 4587], 32000, 4), // input
            new List<int> { 2352, 1 } // expected
        };
  }
}
