using Strategy.Strategies;

namespace Strategy;

public class Hero
{
    public string Name { get; set; }
    public int Hp { get; set; }
    
    public Hero(string name, int hp)
    {
        Name = name;
        Hp = hp;
    }

    public void Attack(IAttackStrategy strategy)
    {
        var result = strategy.Attack();

        var logString = result == 0 ? "Промах!" : "Вы нанесли урон:" + result;
        Console.WriteLine(logString);
    }
}