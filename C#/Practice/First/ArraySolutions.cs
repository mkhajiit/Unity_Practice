class ArraySolutions
{
  public void Run()
  {
    int[] test = {10,20,40,60,100};
    int[] reversedTest = ReverseArray(test);
    Console.WriteLine($"[{string.Join(",",reversedTest)}]");
  }

  private int[] ReverseArray(int[] source)
  {
    int[] result = new int[source.Length];

    for(int i=0; i < source.Length; i++)
    {
      result[i] = source[source.Length -1 -i];
    }

    return result;
  }
}