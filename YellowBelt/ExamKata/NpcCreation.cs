using ExamKata;
namespace ExamKata
{
    public static class NpcCreationLogic
    {
        public static BaseNpc CreateNpc(string name, NpcType type)
        {
            switch (type)
            {
                case NpcType.Merchant:
                    string merchantDialogue = InitializeDialogue.MerchantDialogue();
                    var merchantItems = InitializeShopItems.ItemsDefaultShop();
                    return new MerchantNpc(name, merchantDialogue, merchantItems);
                
                case NpcType.Blacksmith:
                    string blacksmithDialogue = InitializeDialogue.BlacksmithDialogue();
                    var baclsmithItems = InitializeShopItems.ItemsBlacksmithShop();
                    return new MerchantNpc(name, blacksmithDialogue, baclsmithItems);
                
                case NpcType.MagicSeller:
                    string magicDialogue = InitializeDialogue.MagicShopDialogue();
                    var magicItems = InitializeShopItems.ItemsMagicShop();
                    return new MerchantNpc(name, magicDialogue, magicItems);
                
                case NpcType.Default:
                    string thiefDialogue = InitializeDialogue.ThiefDialogue();
                    return new BaseNpc(name, thiefDialogue);
                
                default:
                    string defaultDialogue = InitializeDialogue.DefaultDialogue();
                    return new BaseNpc(name, defaultDialogue);
            }
        }

        public enum NpcType
        {
            Default,
            Merchant,
            Blacksmith,
            MagicSeller
        }
    }

    public class InitializeDialogue
    {
        public static string DefaultDialogue() => "Hello traveller, welcome to our village";
        
        public static string ThiefDialogue() => "Oh my, so sorry for bumping into you";

        public static string MerchantDialogue() => "Ah, a new customer.";

        public static string BlacksmithDialogue() => "I have the best metalwares!";

        public static string MagicShopDialogue() => "Psst! Wanna buy some illegal arcane items?";
    }
    
    public class InitializeShopItems
    {
        public static List<string> ItemsDefaultShop() => new List<string> { "Potion", "Tent", "Antidote" };

        public static List<string> ItemsBlacksmithShop() => new List<string> { "Sword", "Shield", "Helmet", "Armor" };

        public static List<string> ItemsMagicShop() => new List<string> { "Mana Potion", "Spellbook", "Wizard Robe" };
    }
}