// // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число :  ");
int num = int.Parse(Console.ReadLine());
int middle = 0;

if (100 <= num & num < 1000)
{
    middle = num / 10 % 10;
    Console.WriteLine ($"{num}->{middle}");
}

else
{
    Console.WriteLine ("Введено не трехзначное число");
}



