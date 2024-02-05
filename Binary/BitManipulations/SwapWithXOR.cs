namespace Binary;

public class SwapWithXOR
{
  public (int a, int b) Elements(int a, int b)
  {
    a ^= b;
    b ^= a;
    a ^= b;
    return (a,b);
  }

  public (char a, char b) Elements(char a, char b)
  {
    a ^= b;
    b ^= a;
    a ^= b;
    return (a,b);
  }
}
