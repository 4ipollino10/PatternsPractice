namespace Strategy.Strategies;

public class AxeAttackStrategy : IAttackStrategy
{
    private const int WeaponLowDamage = 15;
    private const int WeaponHighDamage = 19;
    private const double ChanceToMiss = 50;
    
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