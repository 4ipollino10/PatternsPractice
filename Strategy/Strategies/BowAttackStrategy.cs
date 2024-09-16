namespace Strategy.Strategies;

public class BowAttackStrategy : IAttackStrategy
{
    private const int WeaponDamage = 7;
    
    public int Attack()
    {
        var result = WeaponDamage;

        return result;
    }
}