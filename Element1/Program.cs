//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёх значтное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = num1 % 100 / 10;
Console.WriteLine(num2);


