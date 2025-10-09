using Heroes;
using Heroes.Heroes;

var Bob = new Wizard("Bob", 74);
var Rob = new Wizard("Rob", 32);
var Robert = new Warrior("Robert", 65);
var Robot = new Warrior("Robot", 109);
var Jon = new Paladin("Jon", 23);
var Jack = new Paladin("Jack", 96);

var HeroManager = new HeroManager<Hero>();

HeroManager.AddHero(Bob);
HeroManager.AddHero(Rob);
HeroManager.AddHero(Robert);
HeroManager.AddHero(Robot);
HeroManager.AddHero(Jon);
HeroManager.AddHero(Jack);
HeroManager.DisplayHeroes();
foreach (var hero in HeroManager.Heroes)
{
    hero.UseAbility();
    hero.LevelUp();
}
HeroManager.DisplayHeroes();

