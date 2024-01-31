namespace Binary.Decimal;

public class MaxContiniousSequenсe
{
  public int GetMaxContiniousSequenсeWithNaive(int[] arr)
  {
    int maxCount = 0;
    int currentCount = 0;
    foreach (var bit in arr)
    {
      if (bit == 1)
      {
        currentCount++;
      }
      else //bit == 0
      {
        if (currentCount > maxCount)
        {
          maxCount = currentCount;
        }
        currentCount = 0;
      }
    }

    return Math.Max(maxCount, currentCount);
  }

  public int GetMaxContiniousSequenсeWithSlidingWindow(int[] arr)
  {
    var slidingWindow = new SlidingWindow();

    while (slidingWindow.End < arr.Length)
    {
      if (arr[slidingWindow.End] == 0)
      {
        int currentValue = slidingWindow.End - slidingWindow.Start;
        if (slidingWindow.Value < currentValue)
        {
          slidingWindow.Value = currentValue;
        }
        slidingWindow.Start = slidingWindow.End + 1;
      }

      slidingWindow.End++;
    }

    int sizeForLastPosition = slidingWindow.End - slidingWindow.Start;

    return Math.Max(slidingWindow.Value, sizeForLastPosition);
  }
}
