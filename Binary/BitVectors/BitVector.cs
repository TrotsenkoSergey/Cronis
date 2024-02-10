namespace Binary.BitVectors;

public class BitVector
{
  private readonly int _vectorSize;
  private readonly int[] _bitVector;

  public BitVector(int bitsCount)
  {
    if (bitsCount < 0) throw new Exception("Bits count must be >= 0");
    else if (bitsCount == 0) _bitVector = [];

    _vectorSize = bitsCount;
    int bucketsCount = ((bitsCount - 1) >> 5) + 1;
    _bitVector = new int[bucketsCount];
  }

  public void SetBit(int bitOrdinalIndex)
  {
    ValidateRange(bitOrdinalIndex);
    int bucketIndex = bitOrdinalIndex >> 5;
    _bitVector[bucketIndex] |= 1 << bitOrdinalIndex;
  }

  public void UnSetBit(int bitOrdinalIndex)
  {
    ValidateRange(bitOrdinalIndex);
    int bucketIndex = bitOrdinalIndex >> 5;
    _bitVector[bucketIndex] &= ~(1 << bitOrdinalIndex);
  }

  public bool GetBit(int bitOrdinalIndex)
  {
    ValidateRange(bitOrdinalIndex);
    int bucketIndex = bitOrdinalIndex >> 5;
    return ((1 << bitOrdinalIndex) & _bitVector[bucketIndex]) != 0;
  }

  private void ValidateRange(int bitOrdinalIndex)
  {
    if (bitOrdinalIndex < 0 || bitOrdinalIndex >= _vectorSize)
      throw new Exception("BitOrdinalIndex must be in a range from 0 to " + (_vectorSize - 1));
  }
}
