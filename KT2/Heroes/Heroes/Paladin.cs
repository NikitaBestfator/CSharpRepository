namespace Heroes.Heroes;

public class Paladin : Hero, IMagicUser, IPhysicalFighter
{
    public Paladin(string name, int level) : base(name, level)
    {
        
    }

    protected override ConsoleColor Color => ConsoleColor.Red;

    public override void UseAbility()
    {
        Write($"Использована способность Удар грома");
    }

    public void CastSpell()
    {
        Write($"Прочитано заклинание");
    }

    public void Attack()
    {
        Write($"Герой аттакует");
    }
}