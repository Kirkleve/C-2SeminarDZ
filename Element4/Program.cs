//Доп. задача: Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. 
//Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше
//Доп. задача с усложнением: на отгадывание дается 3 попытки.
//По возможности использовать функции.

                            //Здесь тренировался с функциями Element4pro обычное решение

int rand = RandomInt(1,100);
int RandomInt(int min, int max)
{
    return new Random ().Next(min, max);
}
Console.WriteLine(rand);
Console.WriteLine("Отгадай число: ");
int mystery = Convert.ToInt32(Console.ReadLine());
int index = 0;

void Print (int arg)
{
    Console.WriteLine(arg);
}

int last = FestChanse(rand, mystery);
int FestChanse(int ran, int mys)
{
    if (ran == mys)
    {
        Console.WriteLine("Мои поздрвавления вы угадали!");
        return ran;
    }
    
        if (ran > mys) 
        {
            Console.WriteLine("Загаданное число больше, попробуй снова");
            index++;
        }
        else 
        {
            Console.WriteLine("Загаданное число меньше, ещё есть попытка");
            index++;
        }     
        int last = Convert.ToInt32(Console.ReadLine());
        return last;
}

int last2 = SecondChanse(rand, last);
int SecondChanse(int ran, int mys)
{
    if (ran == mys )
    {
        Console.WriteLine("Мои поздрвавления вы угадали!");
        return ran;
    }
    if (ran > mys) 
    {
        Console.WriteLine("Загаданное число больше, попробуй снова");
        index++;
    }
    else 
    {
        Console.WriteLine("Загаданное число меньше, ещё есть попытка");
        index++;
    }     
    int last2 = Convert.ToInt32(Console.ReadLine());
    return last2;
}

int lastchense = LastChanse(rand, last2);
int LastChanse(int ran,int mys)
{
    if (ran == mys)
    {
        Console.WriteLine("Мои поздрвавления вы угадали!");
        return ran;
    }
    if (ran > mys) 
    {
        Console.WriteLine("Загаданное число больше, увы ты проиграл");
        return ran;
    }
    else 
    {
        Console.WriteLine("Загаданное число меньше, увы ты проиграл");
        return mys;
    }     
}

while (index < 2)
{
    Print(last);
    Print(last2);
    Print(lastchense);
    
}

