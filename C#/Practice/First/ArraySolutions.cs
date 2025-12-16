class ArraySolutions
{
  public void Run()
  {
    int[] test = {10,20,40,60,100};
    int[] reversedTest = ReverseArray(test);
    Console.WriteLine($"[{string.Join(",",reversedTest)}]");
    Console.WriteLine($"뒤집힌 문자열: {ReverseString("start")}");
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

  private string ReverseString(string source)
  {
    var array = source.Reverse().ToArray(); //배열이 아닌 열거 시퀀스 상태(Reverse) => 배열상태로 변환한다(ToArray)
    string reversed = new string(array); // 배열 => 문자열

    return reversed;
  }
}