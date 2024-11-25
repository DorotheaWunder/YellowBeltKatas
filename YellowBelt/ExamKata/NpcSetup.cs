using ExamKata;
namespace ExamKata
{
    public interface INpc
    {
        string Name { get; }
        string Dialogue { get; }
        void Speak(); 
    }
    
    public class BaseNpc : INpc
    {
        public string Name { get; private set; }

        public string Dialogue { get; private set; }
        

        public BaseNpc(string name, string dialogue)
        {
            Name = name;
            Dialogue = dialogue;
        }

        public void Speak()
        {
            Console.WriteLine($"{Name}: {Dialogue}");
        }
    }

    public class MerchantNpc : BaseNpc
    {
        public List<Item> ItemList { get; private set; }

        public MerchantNpc(string name, string dialogue, List<Item> itemList)
            : base(name,dialogue)
        {
            ItemList = itemList;
        }
        
        public void Trade(CombatantSetup.Player player)//player as parameter, yes or no?
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Just look around:");
            
            for(int i = 0; i < ItemList.Count; i++)
            {
                Thread.Sleep(300);
                Console.WriteLine($"{i + 1} ----- {ItemList[i].Name}: {ItemList[i].Price} Gold");
            }
            
            Console.WriteLine($"------------- {player.Gold} GOLD -------------");
            Console.WriteLine("Enter the number of the item you want to buy --- enter 0 to exit");
            Console.WriteLine("----------------------------");
            
            string input = Console.ReadLine();
            int shopChoice;
            if (int.TryParse(input, out shopChoice))
            {
                switch (shopChoice)
                {
                    case 0: 
                        Console.WriteLine("Come back any time");
                        return;
                    case int n when(n > 0 && n <= ItemList.Count):
                        var chosenItem = ItemList[n - 1];
                        if (player.Gold >= chosenItem.Price)
                        {
                            player.Gold -= chosenItem.Price;
                            Console.WriteLine($"You purchased {chosenItem.Name} for {chosenItem.Price} Gold");
                        }
                        else
                        {
                            Console.WriteLine($"Looks like you don't have enough gold to afford a {chosenItem.Name}");
                        }
                        break;
                    
                    default:
                        Console.WriteLine("Please enter the number of the item you want to buy");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter the number of the item you want to buy");
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Item(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}