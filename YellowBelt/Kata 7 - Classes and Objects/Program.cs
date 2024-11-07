using System.Xml;

class ProgramKata7
{
    static void Main()
    {
        Combat_K7 combat = new Combat_K7();
        combat.Fight();
    }
}

class Player_K7
{
    public string PlayerName { get; set; }
    public int PlayerHealth { get; set; }
    
    public int PlayerDamage { get; set; }
    public int PlayerLevel { get; set; }
    public int PlayerExperience { get; set; }

    public Player_K7(string name, int health,int damage, int level, int experience)
    {
        PlayerName = name;
        PlayerHealth = health;
        PlayerDamage = damage;
        PlayerLevel = level;
        PlayerExperience = experience;
    }

    public void Attack(Enemy_K7 enemy, int damage)
    {
        damage = PlayerDamage;
        Console.WriteLine($"{PlayerName} attacks the {enemy.EnemyType} and deals {damage} damage");
        enemy.TakeDamage(damage);
    }
    
    public void GainExperience(int exp)
    {
        Console.WriteLine($"{PlayerName} gained {exp} experience");
    }
}

class Enemy_K7
{
    public string EnemyType { get; set; }
    public int EnemyHealth { get; set; }
    public int EnemyDamage { get; set; }

    public Enemy_K7(string type, int health, int damage)
    {
        EnemyType = type;
        EnemyHealth = health;
        EnemyDamage = damage;
    }
    
    public void TakeDamage(int damage)
    {
        if(EnemyHealth > 0)
        {
            EnemyHealth -= damage;
            Console.WriteLine($"{EnemyType} took {damage} damage");
            Console.WriteLine($"It now has {EnemyHealth} health");
        }
        else
        {
            Console.WriteLine($"{EnemyType} was defeated");
        }
    }
}

class Combat_K7
{
    Player_K7 player = new Player_K7("Guts",100, 10,1, 0);
    Enemy_K7 enemy = new Enemy_K7("Orc", 50, 10);
    
    public void Fight()
    {
        while (enemy.EnemyHealth > 0)
        {
            player.Attack(enemy, player.PlayerDamage);
            Console.WriteLine();
        }
        Console.WriteLine($"{enemy.EnemyType} was defeated");
        player.GainExperience(50);
    }
}