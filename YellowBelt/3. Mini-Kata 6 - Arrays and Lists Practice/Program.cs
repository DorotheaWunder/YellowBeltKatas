class ProgramMiniKata6
{
    static void Main()
    {
        Game game = new();
        string[] enemyArray = game.InitializeEnemies();
        List<string> itemList = game.InitializeItems();
        
        PrintInfo.PrintArray(enemyArray);
        Console.WriteLine();
        PrintInfo.PrintList(itemList);
        Console.WriteLine();
        itemList.Add("Helmet");
        PrintInfo.PrintList(itemList);
    }
}

class Game()
{
    public string[] InitializeEnemies()
    {
        return new string[3] { "Goblin", "Orc", "Troll" };
    }

    public List<string> InitializeItems()
    {
        return new List<string> { "Sword", "Shield", "Potion"};
    }
}

public class PrintInfo
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
        foreach (var  item  in listContent)
        {
            Console.WriteLine(item);
        }
    }
}

