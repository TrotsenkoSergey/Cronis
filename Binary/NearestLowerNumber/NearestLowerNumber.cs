namespace Binary;

public abstract class NearestLowerNumber
{
    public int[]? GetNearestLowerNumber(int[] input)
    {
        if (Invalid(input)) return null;

        int divisionIndex = GetDivisionIndex(input);
        if (divisionIndex == -1) return ValueIfWeCantGetDivisionIndex(input);

        int[] subArray = GetSubArray(input, divisionIndex);
        int minValueAfterFirstElement = FindMinValueGreaterThenFirstElement(subArray);

        // find index of min value and swap with firstElement
        int indexMinValue = subArray
          .Select((element, index) => (Element: element, Index: index))
          .Where(x => x.Element == minValueAfterFirstElement)
          .First().Index;

        Swap(subArray, 0, indexMinValue);

        // order next values by asc and add firstElement
        subArray[0] = 0;
        subArray = subArray.OrderBy(x => x).ToArray();
        subArray[0] = minValueAfterFirstElement;

        FillInputWithSubArr(input, divisionIndex, subArray);

        return input;
    }

    protected abstract bool Invalid(int[] input);
    
    protected abstract int[]? ValueIfWeCantGetDivisionIndex(int[] input);
    
    protected abstract int FindMinValueGreaterThenFirstElement(int[] subArray);

    protected int GetDivisionIndex(int[] input)
    {
        int startIndex = input.Length - 2;
        for (int currentIndex = startIndex; currentIndex >= 0; currentIndex--)
        {
            int previousIndex = currentIndex + 1;
            if (input[currentIndex] < input[previousIndex])
            {
                return currentIndex;
            }
        }

        return -1;
    }

    protected int[] GetSubArray(int[] input, int divisionIndex)
    {
        var subArray = new int[input.Length - divisionIndex];
        for (int i = divisionIndex, j = 0; i < input.Length; i++, j++)
        {
            subArray[j] = input[i];
        }

        return subArray;
    }

    protected void FillInputWithSubArr(int[] input, int divisionIndex, int[] subArr)
    {
        for (int inputArrIndex = divisionIndex, subArrIndex = 0;
            inputArrIndex < input.Length; inputArrIndex++, subArrIndex++)
        {
            input[inputArrIndex] = subArr[subArrIndex];
        }
    }

    protected void Swap(int[] arr, int firstIndex, int secondIndex)
    {
        int temp = arr[firstIndex];
        arr[firstIndex] = arr[secondIndex];
        arr[secondIndex] = temp;
    }
}
