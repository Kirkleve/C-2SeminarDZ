// решение через функцию доп задачи

//Доп. задача: Игра угадайка. Программа загадывает случайное число. 
//Пользователь его угадывает. Если пользователь дает неправильный ответ, 
//то программа сообщает, больше загаданное число или меньше
//Доп. задача с усложнением: на отгадывание дается 3 попытки.

//По возможности использовать функции.

int rand = RandomInt(1, 100);
int RandomInt(int min, int max)
{
    return new Random().Next(min, max);
}
Console.WriteLine(rand);
Console.WriteLine("Отгадай число: ");
int mystery = Convert.ToInt32(Console.ReadLine());


void Search(int ran, int mys)
{

    if (ran > mys)
    {
        Console.WriteLine("Загаданное число больше, попробуй снова");
    }
    else if (ran == mys)
    {
        Console.WriteLine("Ура, вы выйграли");
    }
    else
    {
        Console.WriteLine("Загаданное число меньше, ещё есть попытка");
    }
}


Search(rand, mystery);
if (rand < mystery || rand > mystery)
{
    mystery = Convert.ToInt32(Console.ReadLine());
    Search(rand, mystery);
}
if (rand < mystery || rand > mystery)
{
    mystery = Convert.ToInt32(Console.ReadLine());
    Search(rand, mystery);
}