class ProgramKata5
{
    static void AttackEnemy(string enemyName, int damage)
    {
        Console.WriteLine($"{enemyName} was attacked and lost {damage} HP");
    }

    static void HealPlayer(string playerName, int healAmount)
    {
        Console.WriteLine($"{playerName} cast a healing spell and restored {healAmount} HP");
    }

    static void Main()
    {
        AttackEnemy("Goblin", 15);
        HealPlayer("Hans-Peter", 20);
        AttackEnemy("Mimic", 50);
        HealPlayer("Karl-Heinz", 10);
    }
}
