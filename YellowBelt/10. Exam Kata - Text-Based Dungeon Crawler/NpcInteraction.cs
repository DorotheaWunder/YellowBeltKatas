using Kata10Exam;
namespace Kata10Exam
{
    public class NpcInteraction
    {
        public void MeetDefaultNpc()
        {
            BaseNpc npc1 = NpcCreationLogic.CreateNpc("ELDER HANS-PETER", NpcCreationLogic.NpcType.Default);
            Console.WriteLine("An old man is standing near the village gate");
            npc1.Speak();
        }
        
        public void MeetThiefNpc()
        {
            BaseNpc npc2 = NpcCreationLogic.CreateNpc("VERY UNSUSPICIOUS CITIZEN", NpcCreationLogic.NpcType.Default);
            Console.WriteLine("Oh my, sorry for bumping into you");
            npc2.Speak();
        }

        public void MeetMerchant()
        {
            MerchantNpc merchant = 
                (MerchantNpc)NpcCreationLogic.CreateNpc("SHOPKEEPER HORST", NpcCreationLogic.NpcType.Merchant);
            Console.WriteLine("As you enter the shop, you are greeted by the merchant");
            merchant.Speak();
            merchant.Trade();
            Console.WriteLine("this is the part where you would be able to buy items - but alas - the programmer ran out of time...");
            Console.WriteLine("----- back to the village you go! -----");
        }

        public void MeetBlacksmith()
        {
            MerchantNpc blacksmith =
                (MerchantNpc)NpcCreationLogic.CreateNpc("BLACKSMITH RUDIGER", NpcCreationLogic.NpcType.Blacksmith);
            Console.WriteLine("You walk by a smithy and a bulky man calls out to you");
            blacksmith.Speak();
            blacksmith.Trade();
            Console.WriteLine("this is the part where you would be able to buy items - but alas - the programmer ran out of time...");
            Console.WriteLine("----- back to the village you go! -----");
        }

        public void MeetMagicseller()
        {
            MerchantNpc magicseller = 
                (MerchantNpc)NpcCreationLogic.CreateNpc("KALKOFE", NpcCreationLogic.NpcType.MagicSeller);
            Console.WriteLine("A voice comoing out of a shady alleyway startles you");
            magicseller.Speak();
            magicseller.Trade();
            Console.WriteLine("this is the part where you would be able to buy items - but alas - the programmer ran out of time...");
            Console.WriteLine("----- back to the village you go! -----");
        }
    }
}