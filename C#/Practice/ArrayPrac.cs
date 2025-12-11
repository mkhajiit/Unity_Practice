using System.Text;
class ArrayPrac
{
  List<string> students = new List<string>();
  public void Run()
  {
    Console.InputEncoding = Encoding.UTF8;
    Console.OutputEncoding = Encoding.UTF8;

    while(true)
    {
      string input = ShowInputInfo();
      if(input.ToLower() == "exit" || input == "")
      {
        Console.WriteLine("입력종료");
        break;
      }
      AddStudent(input);
    }
    PrintStudent();
  }

  private string ShowInputInfo()
  {
    Console.WriteLine("추가할 학생의 이름을 입력하세요:");
    string studentName = Console.ReadLine();
    return studentName;
  }

  private void AddStudent(string name)
  {
    students.Add(name);
  }

  private void PrintStudent()
  {
    Console.WriteLine("\n등록된 학생 목록:");

    foreach(string n in students)
    {
      Console.WriteLine($"학생이름:{n}");
    }
  }
}