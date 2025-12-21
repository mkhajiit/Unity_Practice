class TransPrac
{
  public void Run()
  {
    int a = 12;
    int b = 3;

    string asbing = "aisa";
    string bs = "bisb";

    string result = a.ToString() + b.ToString();

    string secondResult = asbing.Substring(1,2) + bs.Substring(0,3); 

    string answer = string.Concat(Enumerable.Repeat(secondResult,5));

    Console.WriteLine(int.Parse(result));
    Console.WriteLine(answer);
  }
}