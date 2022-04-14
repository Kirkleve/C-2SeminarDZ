//Доп. задача: Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. 
//Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше
//Доп. задача с усложнением: на отгадывание дается 3 попытки.
//По возможности использовать функции.

Console.WriteLine("Отгадай число: ");

int Mystery = Convert.ToInt32(Console.ReadLine());

int Rand = new Random ().Next(1,1000);

int index = 0;

while (index < 3)
{
    if (Mystery == Rand)
    {
        Console.WriteLine("Мои поздрвавления вы угадали!))");
    }
    else
    {
        if (Rand > Mystery)
        {
            Console.WriteLine("Больше");
            index++;
        }
        else
        {
            Console.WriteLine("Меньше");
            index++;
        }
        return;
    }
}

