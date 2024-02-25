public class CharacterData
{
    private int _initialHealth;
    private int _initialLevel;

    public int InitialHealth => _initialHealth;
    public int InitialLevel => _initialLevel;

    public CharacterData(int initialHealth, int initialLevel)
    {
        _initialHealth = initialHealth;
        _initialLevel = initialLevel;
    }
}
