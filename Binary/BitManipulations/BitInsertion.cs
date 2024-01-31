namespace Binary;

public class BitInsertion
{
  public int InsertAtRange(int main, int insertion, int startRange, int endRange)
  {
    int range = endRange - startRange + 1;

    for (int i = 0, j = startRange; i < range; i++, j++)
    {
      int insertionBit = insertion.GetLowestBit();
      insertion >>>= 1;
      int currentBit = main.GetBitAt(j);
      if (insertion != currentBit)
      {
        main = main.InvertBitAt(j);
      }
    }

    return main;
  }
}
