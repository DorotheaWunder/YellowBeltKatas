class ProgramKata5
{
    private static int PlayerHealth { get; set; } = 100;
    private static int EnemyHealth { get; set; } = 100;
    
    static void Attack(int damage)
    {
        EnemyHealth -= damage;
        Console.WriteLine($"The player dealt {damage} damage");
    }
    
    static void Heal(int healAmounnt)
    {
        PlayerHealth += healAmounnt;
        Console.WriteLine($"The player healed {healAmounnt} HP");
    }
    
    static void DisplayStats()
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine($"Current player health: {PlayerHealth}");
        Console.WriteLine($"Current enemy health: {EnemyHealth}");
        Console.WriteLine("--------------------------------------");
    }
    
    static void Main()
    {
        DisplayStats();
        Attack(10);
        Heal(20);
        DisplayStats();
    }
}






    

