namespace Kata10;

class ProgramKata10
{
    static void Main()
    {
        //-------------------------------------------combat part
        Player_K10 playerA = new Player_K10("Horst Seehofer", 10, 50);
        Player_K10 playerB = new Player_K10("Heinrich", 30, 20);
        Enemy_K10 enemyOrc = new Enemy_K10("Orc", 15, 40);
        Enemy_K10 enemyGoblin = new Enemy_K10("Goblin", 5, 30);

        Console.WriteLine($"The epic battle begins ----- Our heroes {playerA.Name} and {playerB.Name} are fighting against a fearsome {enemyOrc.Name} and a cunning {enemyGoblin.Name}");
        playerA.Attack(enemyGoblin);
        playerB.Attack(enemyOrc);
        Console.WriteLine();
        Console.WriteLine("But what is that? The enemies are actually fighting back?!");
        enemyOrc.Attack(playerB);
        enemyGoblin.Attack(playerA);
        Console.WriteLine();
        playerA.Damage = 100;
        Console.WriteLine($"{playerA.Name} blames {playerB.Name} for this mishap");
        Console.WriteLine($"{playerA.Name}: You're not getting away with this, {playerB.Name}");
        playerA.Attack(playerB);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"{enemyOrc.Name} and {enemyGoblin.Name} are confused by this outcome and decide to go home...");


        //-------------------------------------------npc part
        Console.WriteLine();
        Console.WriteLine();
        DefaultNpc_10 npc = new DefaultNpc_10("Elfriede");
        npc.Speak();
        Console.WriteLine();
        List<string> itemListA = InitializeItems.ItemsBlacksmithShop();
        INpc blacksmith = new Merchant_10("Blacksmith Steve", itemListA);
        blacksmith.Speak();
        ((Merchant_10)blacksmith).Trade(itemListA);
        Console.WriteLine();
        List<string> itemListB = InitializeItems.ItemsDefaultShop();
        INpc merchant = new Merchant_10("Shopkeeper Gudrun", itemListB);
        merchant.Speak();
        ((Merchant_10)merchant).Trade(itemListB);
        Console.WriteLine();
        List<string> itemListC = InitializeItems.ItemsMagicShop();
        INpc priest = new Merchant_10("Priest Norbert", itemListC);
        priest.Speak();
        ((Merchant_10)priest).Trade(itemListC);
    }
}

//combat in its own class right now - needs refactoring
//-------------------------------------------combat part
public interface ITarget
{ 
    string Name { get; set; }
    int Health { get; set; }
    void TakeDamage(int damage);
}
public interface IAttacker
{
    int Damage { get; set; }
    void Attack(ITarget target);
}


public abstract class Combatant : ITarget, IAttacker
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }
    
    public Combatant(string name, int damage, int health)
    {
        Name = name;
        Damage = damage;
        Health = health;
    }
    
    public void Attack(ITarget target)
    {
        Console.WriteLine($"{Name} attacks {target.Name} for {Damage} damage.");
        target.TakeDamage(Damage);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} took {damage} damage.");
        Console.WriteLine($"{Name} has {Health} health remaining.");
    }
}

class Player_K10 : Combatant
{
    public string AttackerName { get; set; }
    public string TargetName { get; set; }
    public int Damage { get; set; }
    
    public int TargetHealth { get; set; }

    public Player_K10(string name, int damage, int health) : base(name, damage, health)
    {
        AttackerName = name;
        Damage = damage;
        TargetHealth = health;
    }
}

class Enemy_K10 : Combatant
{
    public string AttackerName { get; set; }
    public string TargetName { get; set; }
    public int Damage { get; set; }
    
    public int TargetHealth { get; set; }
    
    public Enemy_K10(string name, int damage, int health) : base(name, damage, health)
    {
        AttackerName = name;
        Damage = damage;
        TargetHealth = health;
    }
}

//-------------------------------------------npc part
public interface INpc
{ 
    string Name { get; set; }
    string Dialogue { get; set; }
    void Speak(); 
}

class DefaultNpc_10 : INpc
{
    public string Name { get; set; }
    public string Dialogue { get; set; }

    public DefaultNpc_10(string name)
    {
        Name = name;
        Dialogue = InitializeDialogue.DefaultDialogue();
    }
    public void Speak()
    {
        Console.WriteLine($"{Name}: {Dialogue}");
    }
}

class Merchant_10 : INpc
{
    public string Name { get; set; }
    public string Dialogue { get; set; }
    private List<string> _itemList;

    public Merchant_10(string name, List<string> itemList)
    {
        Name = name;
        Dialogue = InitializeDialogue.MerchantDialogue();
        _itemList = itemList;
    }
    
    
    public void Speak()
    {
        Console.WriteLine($"{Name}: {Dialogue}");
    }

    public void Trade(List<string> itemList)
    {
        Console.WriteLine("What do you want to buy?");
        foreach (var item in itemList)
        {
            Console.WriteLine(item);
        }
    }
}

class InitializeItems
{
    public static List<string> ItemsDefaultShop()
    {
        return new List<string> { "Potion", "Tent", "Antidote"};
    }
    
    public static List<string> ItemsBlacksmithShop()
    {
        return new List<string> { "Sword", "Shield", "Helmet", "Armor" };
    }
    
    public static List<string> ItemsMagicShop()
    {
        return new List<string> { "Mana Potion", "Spellbook", "Wizard Robe"};
    }
}

class InitializeDialogue
{
    public static string DefaultDialogue()
    {
        return "Hello traveller, welcome to our village";
    }
    
    public static string MerchantDialogue()
    {
        return "Ah, a new customer.";
    }
}

