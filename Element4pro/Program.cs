int rand = RandomInt(1,100);
int RandomInt(int min, int max)
{
    return new Random ().Next(min, max);
}
Console.WriteLine(rand);
Console.WriteLine("Отгадай число: ");
int mystery = Convert.ToInt32(Console.ReadLine());

int index = 0;


while (index < 2)
{
    if (mystery == rand)
    {
        Console.WriteLine("Мои поздрвавления вы угадали!))");
        break;
    }    
    if (rand > mystery) 
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
    
    if (rand > last) 
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
    
    if (rand > last2) 
    {
        Console.WriteLine("Загаданное число больше, увы ты проиграл");
        break;
    }
    else 
    {
        Console.WriteLine("Загаданное число меньше, увы ты проиграл");
        break;
    }     
}
Console.WriteLine("игра закончина");