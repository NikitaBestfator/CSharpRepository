using Heroes.Heroes;

namespace Heroes;

public class HeroManager<T>
where T : Hero
{
    public List<T> Heroes { get; } = new List<T>();
    public void AddHero(T hero)
    {
        Heroes.Add(hero);
    }

    public void LevelUpHero(string name)
    {
        Heroes.Find(i=>i.Name == name)?.LevelUp();
    }

    public void DisplayHeroes()
    {
        foreach (var hero in Heroes)
        {
            hero.Display();
        }
    }
}