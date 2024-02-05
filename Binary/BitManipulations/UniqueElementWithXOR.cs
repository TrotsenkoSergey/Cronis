namespace Binary;

public class UniqueElementWithXOR
{
  public int GetUnique(int[] arr)
  {
    int unique = arr[0];

    if (arr.Length == 1) return unique;

    for (int i = 1; i < arr.Length; i++)
    {
      unique ^= arr[i];
    }

    return unique;
  }
}
