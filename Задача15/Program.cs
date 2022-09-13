// // Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введи цифру: ");
int num = int.Parse(Console.ReadLine());

void DayCheck (int num) 
{
  if (num == 6 || num == 7) 
  {
  Console.WriteLine("(этот день выходной) -> да");
  }

  else if (num < 1 || num > 7) 
  {
    Console.WriteLine("Это цифра не может быт номером дня недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}
DayCheck(num);