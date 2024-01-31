namespace Binary;

public class OnesBitInsertion
{
  public byte[] CreateArray(int buckets, int startBucket, int startIndex, int endBucket, int endIndex)
  {
    byte[] arr = new byte[buckets];
    if (startBucket == endBucket)
    {
      for (int i = startIndex; i <= endIndex; i++)
      {
        arr[startBucket] = arr[startBucket].SetBitOneAt(i);
      }
      return arr;
    }

    for (int i = startBucket; i <= endBucket; i++)
    {
      byte newElement = 0;
      if (i == startBucket)
      {
        int range = startIndex + 1;
        newElement = arr[i].SetBitOneInLowestRange(range);
      }
      else if (i == endBucket)
      {
        int range = 8 - endBucket + 1;
        newElement = arr[i].SetBitOneInHighestRange(range);
      }
      else // between startBucket and endBucket
      {
        int range = 8;
        newElement = arr[i].SetBitOneInLowestRange(range);
      }
      arr[i] = newElement;
    }

    return arr;
  }
}
