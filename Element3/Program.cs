// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число от 1 до 7, где число является днём недели");
int date = Convert.ToInt32(Console.ReadLine());

if (date >7)
{
    Console.WriteLine("Сказанно же от 1 до 7, что не понятно?");
}
else 
{
    if (date < 5)
    {
        Console.WriteLine("Это будний день");
    }
    else 
    {
        Console.WriteLine("Это выходной день");
    }
}