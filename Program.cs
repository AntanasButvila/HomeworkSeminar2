// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 1000 && number > 99 )
{
  
int firstDigit = number / 100;
int secondDigit = number / 10;
int result = secondDigit - (firstDigit * 10);

Console.WriteLine($" {number} -> {result}");
}
else
{
    Console.Write("Вы ввели не трехзначное число!");
}