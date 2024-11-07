class ProgramKata8
{
    static void Main()
    {
        Player_K8 player = new Player_K8();
        
        player.GainExperience(50);
        player.GainExperience(60);
        player.GainExperience(70);
        player.GainExperience(30);
    }
}

class Player_K8
{
    public string PlayerName = "Segobald";
    
    private int _playerHealth;
    private int _playerLevel;
    private int _playerExperience;


    public int Health
    {
        get { return _playerHealth; }

        private set
        {
            if (_playerHealth >= 0) { _playerHealth = value; }
        }
    }
    
    public int Level
    {
        get { return _playerLevel; }

        private set
        {
            if (value >= 0) { _playerLevel = value; }
        }
    }
    
    public int Experience
    {
        get { return _playerExperience; }

        private set
        {
            if (value >= 0) { _playerExperience = value; }
        }
    }
    
    
    
    private void LevelUp()
    {
        _playerLevel++;
        Console.WriteLine($"{PlayerName} leveled up and reached level {_playerLevel}");
        _playerExperience = 0;
    }
    
    public void GainExperience(int exp)
    {
        _playerExperience += exp;
        Console.WriteLine($"{PlayerName} gained {exp} experience");
        
        if (_playerExperience >= 100)
        {
            LevelUp();
        }
    }
}