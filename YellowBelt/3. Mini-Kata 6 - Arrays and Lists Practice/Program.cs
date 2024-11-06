class ProgramMiniKata6
{
    static void Main()
    {
        Game_MK6 game= new();
        string[] enemyArray = game.InitializeEnemies();
        List<string> itemList = game.InitializeItems();
        
        PrintInfo_MK6.PrintArray(enemyArray);
        Console.WriteLine();
        PrintInfo_MK6.PrintList(itemList);
        Console.WriteLine();
        itemList.Add("Helmet");
        PrintInfo_MK6.PrintList(itemList);
    }
}

class Game_MK6()
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

public class PrintInfo_MK6
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

