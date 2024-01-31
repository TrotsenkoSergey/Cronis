namespace Binary;

public static class Bits
{
  public static int GetLowestBit(this int data) =>
    (int)(1u & data);

  public static int GetHighestBit(this int data) =>
    data >>> 31;

  public static Stack<int> LowToHigh(int data) //(для 32 битов)
  {
    var bits = new Stack<int>();
    for (int i = 0; i < 32; i++) //или while(data != 0)
    {
      int bit = data.GetLowestBit();
      bits.Push(bit);
      data = data >>> 1;
    }
    return bits;
  }

  public static Stack<int> HighToLow(int data) //(для 32 битов)
  {
    var bits = new Stack<int>();
    for (int i = 0; i < 32; i++) //или while(data != 0)
    {
      int bit = data.GetHighestBit();
      bits.Push(bit);
      data = data << 1;
    }
    return bits;
  }

  public static void Print(Stack<int> bits)
  {
    foreach (int bit in bits)
    {
      Console.Write(bit);
    }

    Console.WriteLine();
  }

  public static int GetBitAt(this int data, int index) =>
    (int)((data >>> index) & 1u);

  public static bool IsBitOneAt(this int data, int index) =>
    ((int)((1u << index) & data)) != 0;

  public static int InvertBitAt(this int data, int index) =>
    (int)((1u << index) ^ data);

  public static int SetBitOneAt(this int data, int index) =>
    (int)((1u << index) | data);

  public static int SetBitZeroAt(this int data, int index) =>
    (int)(~(1u << index) & data);

  public static int SetBitZeroAtLowestRange(this int data, int range) =>
    (int)((~0u << range) & data);

  public static int SetBitOneInLowestRange(this int data, int range) =>
    (int)(~(~0u << range) | data);

  public static int SetBitZeroInHighestRange(this int data, int range) =>
    (int)((~0u >>> range) & data);

  public static int SetBitOneInHighestRange(this int data, int range) =>
    (int)(~(~0u >>> range) | data);

  // byte section
  public static byte SetBitOneAt(this byte data, int index) =>
    (byte)((byte)(1u << index) | data);

  public static byte SetBitZeroAtLowestRange(this byte data, int range) =>
    (byte)((~0u << range) & data);

  public static byte SetBitOneInLowestRange(this byte data, int range) =>
    (byte)(~(~0u << range) | data);

  public static byte SetBitZeroInHighestRange(this byte data, int range)
  {
    uint shiftRight = ~0u >>> range;
    byte reverseByte = (byte)(shiftRight >>> 24);
    return (byte)(reverseByte & data);
  }

  public static byte SetBitOneInHighestRange(this byte data, int range)
  {
    uint startOnes = ~(~0u >>> range);
    byte reverseByte = (byte)(startOnes >>> 24);
    return (byte)(reverseByte | data);
  }
}
