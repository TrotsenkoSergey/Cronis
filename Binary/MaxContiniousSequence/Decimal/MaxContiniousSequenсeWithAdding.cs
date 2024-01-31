namespace Binary.Decimal;

public class MaxContiniousSequenсeWithAdding
{
  public int GetMaxContiniousSequenсeWithAddingMy(int[] sequence)
  {
    var slidingWindows = GetSlidingWindows(sequence);
    int maxValue = 0;

    if (slidingWindows.Count != 0)
    {
      maxValue = slidingWindows[0].Value;

      if (slidingWindows.Count > 1)
      {
        for (int i = 1; i < slidingWindows.Count; i++)
        {
          int currentMax = slidingWindows[i].Value;
          if (slidingWindows[i].Start - slidingWindows[i - 1].End - 1 == 1)
          {
            currentMax = slidingWindows[i].Value + slidingWindows[i - 1].Value;
          }

          if (currentMax > maxValue)
          {
            maxValue = currentMax;
          }
        }
      }

      if (slidingWindows[0].Start > 0
        || slidingWindows[slidingWindows.Count - 1].End < sequence.Length - 1
        || slidingWindows.Count > 1)
      {
        maxValue++; // we met more then one zero
      }
    }

    return maxValue;
  }

  public int GetMaxContiniousSequenсeWithAddingCronis(int[] arr)
  {
    int maxSetSize = 0;
    int firstZeroIndex = -1;
    int windowStart = -1;
    int windowEnd = 0;

    while (windowEnd < arr.Length)
    {
      if (arr[windowEnd] == 0)
      {
        int setSize = windowEnd - windowStart;
        maxSetSize = Math.Max(maxSetSize, setSize);
        windowStart = firstZeroIndex + 1;
        firstZeroIndex = windowEnd;
      }
      windowEnd++;
    }

    if (windowStart == -1) return arr.Length;

    return Math.Max(maxSetSize, windowEnd - windowStart);
  }

  private List<SlidingWindow> GetSlidingWindows(int[] sequence)
  {
    var slidingWindows = new List<SlidingWindow>();
    SlidingWindow? currentWindow = null;

    for (int i = 0; i < sequence.Length; i++)
    {
      int bit = sequence[i];
      if (bit == 1 && currentWindow is not null)
      {
        currentWindow.End = i;
        currentWindow.Value += bit;
      }
      else if (bit == 1 && currentWindow is null)
      {
        currentWindow = new()
        {
          Start = i,
          End = i,
          Value = bit
        };
      }
      else if (bit == 0)
      {
        if (currentWindow is not null)
        {
          slidingWindows.Add(currentWindow);
          currentWindow = null;
        }
      }
    }

    if (currentWindow is not null)
    {
      slidingWindows.Add(currentWindow);
    }

    return slidingWindows;
  }
}