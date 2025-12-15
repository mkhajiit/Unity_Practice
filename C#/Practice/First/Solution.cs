class Solution
{
  public void Run()
  {
    Console.WriteLine("숫자를 입력하세요");
    string? input = Console.ReadLine();
    int result = ParseStringToInt(input);
    Console.WriteLine($"변환 결과:{result}");

    int[] createdArray = InitializeArray(5);

    Console.WriteLine($"[{string.Join(",", createdArray)}]");
  }
  
  private int ParseStringToInt(string? str) //nullable
  {
    if(int.TryParse(str,out int n))
    {
      return n;
    }

    return 0; // 변환 실패시 반환 값
  }

  private int[] InitializeArray(int count)
  {
    int[] myArr = new int[count];

    for(int i =0 ; i < count  ; i++)
    {
      myArr[i] = i * 2;
    }

    return myArr;
  }
}