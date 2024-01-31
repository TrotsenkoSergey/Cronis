namespace Binary.Bin;

public class MaxContiniousSequenсeWithAdditionalOne
{
  public int GetMaxSubSetSizeWithAdditionalOne(int data)
  {
    if (data == 0) return 1;
    if (data == ~0) return 32;

    int maxSetSize = 0;
    int firstZeroIndex = -1;
    int windowStart = -1;
    int windowEnd = 0;

    while (data != 0)
    {
      if ((data & 1) == 0)
      {
        int setSize = windowEnd - windowStart;
        maxSetSize = Math.Max(maxSetSize, setSize);
        windowStart = firstZeroIndex + 1;
        firstZeroIndex = windowEnd;
      }
      windowEnd++;
      data >>>= 1;
    }

    return Math.Max(maxSetSize, windowEnd - windowStart);
  }
}
