class ProgramKata6
{
    static void Main()
    {
        Game_K6 game = new();
        string[] enemyArray = game.InitializeEnemies();
        List<string> itemList = game.InitializeItems();
        
        PrintInfo_K6.PrintArray(enemyArray);
        Console.WriteLine();
        PrintInfo_K6.PrintList(itemList);
        Console.WriteLine($"The list has {itemList.Count} items");
        
        Console.WriteLine();
        itemList.Add("Helmet");
        itemList.Add("Armor");
        Console.WriteLine();
        PrintInfo_K6.PrintList(itemList);
        Console.WriteLine($"The list has {itemList.Count} items");
        
        Console.WriteLine();
        itemList.Remove("Potion");
        PrintInfo_K6.PrintList(itemList);
        Console.WriteLine($"The list has {itemList.Count} items");

        //DRY principle on printing list numbers?
    }
}


class Game_K6
{
    public string[] InitializeEnemies()
    {
        return new string[5] { "Goblin", "Orc", "Troll", "Skeleton", "Dragon" };
    }

    public List<string> InitializeItems()
    {
        return new List<string> { "Sword", "Shield", "Potion" };

    }
}

public class PrintInfo_K6
{
    public static void PrintArray(string[] arrayContent)
    {
        for (int i = 0; i < arrayContent.Length; i++)
        {
            Console.WriteLine(arrayContent[i]);
        }
    }
    
    public static void PrintList(List<string> listContent)
    {
        foreach (var item in listContent)
        {
            Console.WriteLine(item);
        }
    }
}