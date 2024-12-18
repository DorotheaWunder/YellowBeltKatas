﻿using ExamKata;
namespace ExamKata
{
    public class NpcInteraction
    {
        private CombatantSetup.Player _player;

        public NpcInteraction(CombatantSetup.Player player)
        {
            _player = player;
        }
        
        public void MeetDefaultNpc()
        {
            Console.WriteLine();
            BaseNpc npc1 = NpcCreationLogic.CreateNpc("ELDER HANS-PETER", NpcCreationLogic.NpcType.Default);
            Thread.Sleep(500);
            Console.WriteLine("An old man is standing near the village gate");
            npc1.Speak();
        }
        
        public void MeetThiefNpc()
        {
            Console.WriteLine();
            BaseNpc npc2 = NpcCreationLogic.CreateNpc("VERY UNSUSPICIOUS CITIZEN", NpcCreationLogic.NpcType.Default);
            Thread.Sleep(500);
            Console.WriteLine("Oh my, sorry for bumping into you");
            _player.Gold -= 10;
            npc2.Speak();
        }

        public void MeetMerchant()
        {
            Console.WriteLine();
            MerchantNpc merchant = 
                (MerchantNpc)NpcCreationLogic.CreateNpc("SHOPKEEPER HORST", NpcCreationLogic.NpcType.Merchant);
            Thread.Sleep(500);
            Console.WriteLine("As you enter the shop, you are greeted by the merchant");
            merchant.Speak();
            Thread.Sleep(300);
            merchant.Trade(_player);
            Thread.Sleep(1000);
        }

        public void MeetBlacksmith()
        {
            Console.WriteLine();
            MerchantNpc blacksmith =
                (MerchantNpc)NpcCreationLogic.CreateNpc("BLACKSMITH RUDIGER", NpcCreationLogic.NpcType.Blacksmith);
            Thread.Sleep(500);
            Console.WriteLine("You walk by a smithy and a bulky man calls out to you");
            blacksmith.Speak();
            Thread.Sleep(300);
            blacksmith.Trade(_player);
            Thread.Sleep(1000);
        }

        public void MeetMagicseller()
        {
            Console.WriteLine();
            MerchantNpc magicseller = 
                (MerchantNpc)NpcCreationLogic.CreateNpc("KALKOFE", NpcCreationLogic.NpcType.MagicSeller);
            Thread.Sleep(500);
            Console.WriteLine("A voice comoing out of a shady alleyway startles you");
            magicseller.Speak();
            Thread.Sleep(300);
            magicseller.Trade(_player);
            Thread.Sleep(1000);
        }
    }
}