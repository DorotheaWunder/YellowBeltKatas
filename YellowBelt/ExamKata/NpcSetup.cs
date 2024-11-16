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
        public List<string> ItemList { get; private set; }

        public MerchantNpc(string name, string dialogue, List<string> itemList)
            : base(name,dialogue)
        {
            ItemList = itemList;
        }
        
        public void Trade()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Just look around:");
            foreach (var item in ItemList)
            {
                Console.WriteLine((ItemList.IndexOf(item) +1) + "-----" + item);
            }
        }
    }
}