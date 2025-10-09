namespace Heroes.Heroes;

public abstract class Hero
{
    public string Name =>  _name;
    private string _name;
    
    public int Level => _level;
    private int _level;

    protected abstract ConsoleColor Color { get;}
    
    protected void Write(string message)
    {
        var tmpClr =  Console.ForegroundColor;
        Console.ForegroundColor = Color;
        Console.WriteLine(message);
        Console.ForegroundColor = tmpClr;
    }
    protected Hero(string name, int level)
    {
        _name = name;
        _level = level;
    }
    public abstract void UseAbility();
    
    public void LevelUp()
    {
        if (GameSettings.IsLevelValid(_level + 1))
        {
            _level++;
        }
    }

    public void Display()
    {
        Write($"{GetType().Name}: Имя: {_name} - Уровень: {_level}");
    }
}