namespace Binary;

public class NearestDecimalLowerNumber : NearestLowerNumber
{
    protected override bool Invalid(int[] input) =>
       input == null || input.Length == 0;

    protected override int[]? ValueIfWeCantGetDivisionIndex(int[] input) => null;

    protected override int FindMinValueGreaterThenFirstElement(int[] subArray)
    {
        // find value which >= firstElement && min in sequence
        return subArray
          .Where((element, index) => index != 0 && element >= subArray[0])
          .Min();
    }
}
