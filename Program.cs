// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number < 1000 && number > 99 )
// {
  
// int firstDigit = number / 100;
// int secondDigit = number / 10;
// int result = secondDigit - (firstDigit * 10);

// Console.WriteLine($" {number} -> {result}");
// }
// else
// {
//     Console.Write("Вы ввели не трехзначное число!");
// }


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number >= 100)
// {
//     while(number >= 1000)
//     {
//         number /= 10;
       
//     }
//     int thirdDigit = number % 10;
//     Console.WriteLine($"{number} -> {thirdDigit}");
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите цифру дня недели, чтобы узнать является ли он выходным : ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number == 7 || number == 6)
// {
//     Console.WriteLine($"{number} -> да");
// }
// else
// {
//     Console.WriteLine("нет");
// }

