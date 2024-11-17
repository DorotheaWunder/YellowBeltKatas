using ExamKata;
namespace ExamKata
{
    public class MasterGameflow
    {
        private CombatantSetup.Player _player;
        private bool _isInVillage;
        private CombatGameflow _combatGameflow;
        private NpcGameflow _npcGameflow;

        public MasterGameflow()
        {
            _npcGameflow = new NpcGameflow(new NpcInteraction(), this);
            _combatGameflow = new CombatGameflow(this);
            _isInVillage = true;
        }
        
        public void RunGame()
        {
            SetupPlayer();
            while (_player.IsPlayerAlive())
            {
                while (_isInVillage)
                {
                    Console.WriteLine("You stand at the entry of a village");
                    Console.WriteLine("If you turn back now you will be attacked");
                
                    _npcGameflow.PathDesciption();
                }
                _combatGameflow.StartCombat();
            }
        }

        public void SetupPlayer()
        {
            _player = new CombatantSetup.Player("", 10, 100, 20);
            NamePlayer();
            _combatGameflow.AssignPlayer(_player);
        }

        public void NamePlayer()
        {
            string playerName = GetPlayerName();
            _player.Name = playerName;
        }
        
        public string GetPlayerName()
        {
            Console.Write("Enter your hero's name: ");
            return Console.ReadLine();
        }

        public void SetIsInVillage(bool newIsInVillage)
        {
            _isInVillage = newIsInVillage;
        }

        public void VillageEnterExit()
        {
            Console.WriteLine("Do you want to leave the village? (y/n)");
            string input = Console.ReadLine()?.ToLower();

            if (input == "y")
            {
                _isInVillage = false;
                Console.WriteLine("You venture out into the wilderness.");
            }
            else if (input == "n")
            {
                Console.WriteLine("You decide to stay in the village.");
            }
            else
            {
                Console.WriteLine("Invalid input. Enter either 'y' or 'n'.");
            }
        }

        public bool GetInVillage()
        {
            return _isInVillage;
        }
    }
}

