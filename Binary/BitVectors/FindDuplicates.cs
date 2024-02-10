namespace Binary.BitVectors;

public class FindDuplicates
{
  public List<int> Find(int[] arr, int maxIntInArr, int maxMemorySizeInKiB)
  {
    // 1 KiB => 1,024 KB
    // 4 KiB => 4,096 KB
    // 4,096 KB => 33_554,432 Bit
    // Т.е. N = 33_554 поместится в 4 KiB или в битовый вектор на 32_001 бит
    const decimal Amount_of_KB_in_Kib = 1.024m;
    const int Byte_in_KB = 1024;
    const int Bits_in_Byte = 8;
    decimal amount_of_KB_in_memorySize = Amount_of_KB_in_Kib * maxMemorySizeInKiB;
    int maxBitsInMemorySize = (int)(amount_of_KB_in_memorySize * Byte_in_KB * Bits_in_Byte);
    if (maxBitsInMemorySize <= maxIntInArr)
      throw new Exception("Max memory size not enough for max integer in array.");

    var bitVector = new BitVector(maxIntInArr + 1);
    List<int> duplicates = [];
    foreach (int el in arr)
    {
      bool bitIsSet = bitVector.GetBit(el);
      if (bitIsSet)
      {
        duplicates.Add(el);
        continue;
      }

      bitVector.SetBit(el);
    }

    return duplicates;
  }
}
