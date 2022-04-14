//Задача 13: Напишите программу, которая выводит третью
//цифру заданного числа или сообщает,
// что третьей цифры нет


Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = num1 % 1000/100;

if (num2 == 0)
{
    Console.WriteLine("третьего числа нет введите трёхзначное число");
}
else
{
    Console.WriteLine(num2);
}


