class ProgramMiniKata7
{
    static void Main()
    {
        Player_MK7 player = new Player_MK7("Horst", 100, 5);
        Enemy_MK7 enemy = new Enemy_MK7("Goblin", 50, 10 );
        
        Console.WriteLine("Player Info:");
        Console.WriteLine($"Name: {player.PlayerName}");
        Console.WriteLine($"Health: {player.PlayerHealth}");
        Console.WriteLine($"Level: {player.PlayerLevel}");
        Console.WriteLine();
        Console.WriteLine("Enemy Info:");
        Console.WriteLine($"Type: {enemy.EnemyType}");
        Console.WriteLine($"Health: {enemy.EnemyHealth}");
        Console.WriteLine($"Damage: {enemy.EnemyDamage}");
    }
}

class Player_MK7
{
    public string PlayerName { get; set; }
    public int PlayerHealth { get; set; }
    public int PlayerLevel { get; set; }

    public Player_MK7(string name, int health, int level)
    {
        PlayerName = name;
        PlayerHealth = health;
        PlayerLevel = level;
    }
}

class Enemy_MK7
{
    public string EnemyType { get; set; }
    public int EnemyHealth { get; set; }
    public int EnemyDamage { get; set; }

    public Enemy_MK7(string type, int health, int damage)
    {
        EnemyType = type;
        EnemyHealth = health;
        EnemyDamage = damage;
    }
}

