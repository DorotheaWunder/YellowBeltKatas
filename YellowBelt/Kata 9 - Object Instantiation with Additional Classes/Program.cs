class ProgramKata9
{
    static void Main()
    {
        Player_K9 player = InitializeInfo.InitializePlayer();
        Enemy_K9 enemy = InitializeInfo.InitializeEnemy();
        string dialogue = "Hello, welcome to our village";
        NPC_K9 npc = InitializeInfo.InitializeNpc(dialogue);
        List<string> merchantIems = new List<string> { "Sword", "Shield", "Potion"};
        Merchant_K9 merchant = InitializeInfo.InitializeMerchant(merchantIems);

        player.AttackEnemy(enemy, 20);
        Console.WriteLine();
        player.AttackEnemy(enemy, 30);
        Console.WriteLine();
        npc.Speak(dialogue);
        Console.WriteLine();
        merchant.Trade(merchantIems);
        
    }
}

class Player_K9
{
    private string _playerName;
    private int _playerHealth;
    private int _playerLevel;


    public Player_K9(string name, int health, int level)
    {
        _playerName = name;
        _playerHealth = health;
        _playerLevel = level;
    }
    
    
    public string PlayerName
    {
        get { return _playerName; }
        private set { _playerName = value; }
    }
    
    public int PlayerHealth
    {
        get { return _playerHealth; }
        private set { _playerHealth = value; }
    }
    
    public int PlayerLevel
    {
        get { return _playerLevel; }
        private set { _playerLevel = value; }
    }

    public void AttackEnemy(Enemy_K9 enemy, int damageDealt)
    {
        Console.WriteLine($"{_playerName} attacked {enemy.EnemyType} for {damageDealt} damage!");
        enemy.TakeDamage(damageDealt);
    }
}

class Enemy_K9
{
    private string _enemyType;
    private int _enemyHealth;
    private int _damageTaken;
    //was renamed because EnemyDamage was a misleading name because it looks like it's the damage an enemy causes, no receives


    public Enemy_K9(string type, int health, int damage)
    {
        _enemyType = type;
        _enemyHealth = health;
        _damageTaken = 0;
    }
    
    public string EnemyType
    {
        get { return _enemyType; }
        private set { _enemyType = value; }
    }
    
    public int EnemyHealth
    {
        get { return _enemyHealth; }
        private set { _enemyHealth = value; }
    }
    
    public int DamageTaken
    {
        get { return _damageTaken; }
        private set { _damageTaken = value; }
    }

    public void TakeDamage(int damageAmount)
    {
        _damageTaken += damageAmount;
        _enemyHealth -= damageAmount;
        Console.WriteLine($"{_enemyType} was attacked and took {damageAmount} damage! Remaining health: {_enemyHealth}");

        if (_enemyHealth <= 0)
        {
            Console.WriteLine($"{_enemyType} has been defeated");
        }
    }
}

class NPC_K9
{
    private string _npcName;
    private string _npcDialogue;

    public NPC_K9(string name, string dialogue)
    {
        _npcName = name;
        _npcDialogue = dialogue;
    }
    public string NpcName
    {
        get { return _npcName; }
        private set { _npcName = value; }
    }

    public string NpcDialogue
    {
        get { return _npcDialogue; }
        private set { _npcDialogue = value; }
    }
    
    public void Speak(string dialogue)
    {
        Console.WriteLine($"{_npcName} says: {dialogue}");
    }
}

class Merchant_K9
{
    private string _merchantName;
    private List<string> _merchantItems;

    public Merchant_K9(string name, List<string> items)
    {
        _merchantName = name;
        _merchantItems = items;
    }

    public string MerchantName
    {
        get { return _merchantName; }
        private set { _merchantName = value; }
    }
    
    public List<string> MerchantItems
    {
        get { return _merchantItems; }
        private set { _merchantItems = value; }
    }
    
    public void Trade(List<string> merchantItems)
    {
        Console.WriteLine("Hello, what do you want to buy?");
        Console.WriteLine("I have the following:");

        foreach (var item in merchantItems)
        {
            Console.WriteLine(item);
        }

    }
}

static class InitializeInfo
{
    public static Player_K9 InitializePlayer()
    {
        return new Player_K9("Ingeborg", 100, 1);
    }
    
    public static Enemy_K9 InitializeEnemy()
    {
        return new Enemy_K9("Goblin", 50, 20);
    }
    
    public static NPC_K9 InitializeNpc(string dialogue)
    {
        return new NPC_K9("Edeltraut", dialogue);
    }
    
    public static Merchant_K9 InitializeMerchant(List<string> items)
    {
        return new Merchant_K9("Kunigunde", items);
    }
}