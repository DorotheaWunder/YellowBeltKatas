﻿using Kata10Exam;

namespace Kata10Exam
{
    public class NpcGameflow
    {
        public interface IPathAction
        {
            void Execute();
        }
        
        public class GoMarketAction : IPathAction
        {
            private NpcInteraction _npcInteraction;

            public GoMarketAction(NpcInteraction interaction)
            {
                _npcInteraction = interaction;
            }

            public void Execute()
            {
                Console.WriteLine("You are now standing on a bustling marketplace.");
                Console.WriteLine("A man bumps into you and apologizes");
                _npcInteraction.MeetThiefNpc();
                Console.WriteLine("Your purse suddenly feels much lighter");
            }
        }
        
        public class GoMerchantAction : IPathAction
        {
            private NpcInteraction _npcInteraction;

            public GoMerchantAction(NpcInteraction interaction)
            {
                _npcInteraction = interaction;
            }

            public void Execute()
            {
                _npcInteraction.MeetMerchant();
            }
        }
        
        public class GoBlacksmithAction : IPathAction
        {
            private NpcInteraction _npcInteraction;

            public GoBlacksmithAction(NpcInteraction interaction)
            {
                _npcInteraction = interaction;
            }

            public void Execute()
            {
                _npcInteraction.MeetBlacksmith();
            }
        }
        
        public class GoGateAction : IPathAction
        {
            private NpcInteraction _npcInteraction;

            public GoGateAction(NpcInteraction interaction)
            {
                _npcInteraction = interaction;
            }

            public void Execute()
            {
                _npcInteraction.MeetDefaultNpc();
            }
        }
        
        public class GoStreetsAction : IPathAction
        {
            private NpcInteraction _npcInteraction;

            public GoStreetsAction(NpcInteraction interaction)
            {
                _npcInteraction = interaction;
            }

            public void Execute()
            {
                _npcInteraction.MeetMagicseller();
            }
        }
        
        public class LeaveVillageAction : IPathAction
        {
            private NpcInteraction _npcInteraction;

            public LeaveVillageAction(NpcInteraction interaction)
            {
                _npcInteraction = interaction;
            }

            public void Execute()
            {
                Console.WriteLine("You leave the village");
                //in village to false
            }
        }

        
        private readonly Dictionary<int, IPathAction> _pathActions;

        public NpcGameflow(NpcInteraction npcInteraction)
        {
            _pathActions = new Dictionary<int, IPathAction>
            {
                {1, new GoMarketAction(npcInteraction)},
                {2, new GoMerchantAction(npcInteraction)},
                {3, new GoBlacksmithAction(npcInteraction)},
                {4, new GoGateAction(npcInteraction)},
                {5, new GoStreetsAction(npcInteraction)},
                {6, new LeaveVillageAction(npcInteraction)},
            };
        }
        
        public void PathDesciption()
        {
            Console.WriteLine("You are currently in a small village.");
            Console.WriteLine("1 ---- go to the marketplace");
            Console.WriteLine("2 ---- look for a merchant");
            Console.WriteLine("3 ---- seek out a blacksmith");
            Console.WriteLine("4 ---- stroll along the gates");
            Console.WriteLine("5 ---- explore the village streets");
            Console.WriteLine("6 ---- leave the village");
    
            PathChoice();
        }

        public void PathChoice()
        {
            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out int pathNumber) && _pathActions.ContainsKey(pathNumber))
            {
                _pathActions[pathNumber].Execute();
            }
            else
            {
                Console.Write("Whatever you entered it's not a valid choice");
            }
        }
    }
}