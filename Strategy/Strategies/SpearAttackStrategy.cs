namespace Strategy.Strategies;

public class SpearAttackStrategy : IAttackStrategy
{
    private const int WeaponLowDamage = 11;
    private const int WeaponHighDamage = 15;
    private const double ChanceToMiss = 30;
    
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