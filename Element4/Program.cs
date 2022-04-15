//Доп. задача: Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. 
//Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше
//Доп. задача с усложнением: на отгадывание дается 3 попытки.
//По возможности использовать функции.

int Rand = new Random ().Next(1,1000);
Console.WriteLine(Rand);
Console.WriteLine("Отгадай число: ");
int Mystery = Convert.ToInt32(Console.ReadLine());
int index = 0;
while (index < 2)
{
    if (Mystery == Rand)
    {
        Console.WriteLine("Мои поздрвавления вы угадали!))");
        break;
    }
    else
    {
        if (Rand > Mystery)
        {
            Console.WriteLine("Загаданное число больше, попробуй снова");
            
        }
        else
        {
            Console.WriteLine("Загаданное число меньше, ещё есть попытка");
            
        }
    int last = Convert.ToInt32(Console.ReadLine());   
    }
index++;
}
Console.WriteLine("игра закончина");


