namespace Heroes;

public static class GameSettings
{
    private static int MaxLevel = 100;

    public static Boolean IsLevelValid(int level)
    {
        return level <= MaxLevel;
    }
}