namespace Strategy.Strategies;

public class SwordAttackStrategy : IAttackStrategy
{
    private const int WeaponLowDamage = 10;
    private const int WeaponHighDamage = 12;
    private const double ChanceToMiss = 10;
    
    public int Attack()
    {
        var random = new Random();
        var result = 0;
        
        if (random.Next(1, 100) >= ChanceToMiss)
        {
            result = random.Next(WeaponLowDamage, WeaponHighDamage);
        }

        return result;
    }
}