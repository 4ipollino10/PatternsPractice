using Strategy;
using Strategy.Strategies;

var hero = new Hero("Adam", 10);

Console.WriteLine("Вы бьете бесконечно жирного босса");
while (true)
{
    Console.WriteLine("Выберите оружие, которым хотите атаковать:");
    Console.WriteLine("1.Топор");
    Console.WriteLine("2.Меч");
    Console.WriteLine("3.Лук");
    Console.WriteLine("3.Копье");
    Console.WriteLine();

    var key = Console.ReadKey();

    if (key.Key == ConsoleKey.Escape)
    {
        break;
    }
    
    switch (key.Key)
    {
        case ConsoleKey.D1:
            hero.Attack(new AxeAttackStrategy());
            break;
        case ConsoleKey.D2:
            hero.Attack(new SwordAttackStrategy());
            break;
        case ConsoleKey.D3:
            hero.Attack(new BowAttackStrategy());
            break;
        case ConsoleKey.D4:
            hero.Attack(new SpearAttackStrategy());
            break;
    }
}