namespace Heroes.Heroes;

public class Warrior : Hero, IPhysicalFighter
{
    public Warrior(string name, int level) : base(name, level)
    {
        
    }

    protected override ConsoleColor Color => ConsoleColor.Yellow;

    public override void UseAbility()
    {
        Write($"Использована способность Клинок");
    }

    public void Attack()
    {
        Write($"Герой аттакует");
    }
}