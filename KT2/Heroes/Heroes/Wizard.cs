namespace Heroes.Heroes;

public class Wizard : Hero, IMagicUser
{
    public Wizard(string name, int level) : base(name, level)
    {
        
    }

    protected override ConsoleColor Color => ConsoleColor.Green;

    public override void UseAbility()
    {
        Write("Использована способность Огневой шар");
    }

    void IMagicUser.CastSpell()
    {
        Write("Прочитано заклинание");
    }
}