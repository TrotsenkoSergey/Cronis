namespace Binary;

public class NearestBinaryLowerNumber : NearestLowerNumber
{
    const int MaxBitsCount = 32;

    protected override int FindMinValueGreaterThenFirstElement(int[] subArray)
    {
        return 1;
    }

    protected override bool Invalid(int[] input) =>
       input == null || input.Length == 0 || input.Length != MaxBitsCount;

    protected override int[]? ValueIfWeCantGetDivisionIndex(int[] input)
    {
        int inputLength = input.Length;

        int onesCount = 0;
        for (int i = 0; i < inputLength; i++)
            if (input[i] == 1) onesCount++;

        if (onesCount == 0 || onesCount == MaxBitsCount) return null;

        for (int i = inputLength - 1; i >= 0; i--) 
        {
            if (onesCount > 0) input[i] = 1;
            else input[i] = 0;
            onesCount--;
        }

        return input;
    }
}
