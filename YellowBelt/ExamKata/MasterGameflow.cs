using ExamKata;
namespace ExamKata
{
    public class MasterGameflow
    {
        private CombatantSetup.Player _player;
        private CombatGameflow _combatGameflow;
        private NpcGameflow _npcGameflow;

        public MasterGameflow()
        {
            _player = new CombatantSetup.Player("", 10, 100, 20, 1000, true);
            _npcGameflow = new NpcGameflow(new NpcInteraction(_player), this);
            _combatGameflow = new CombatGameflow(this);
        }
        
        public void RunGame()
        {
            SetupPlayer();
            while (_player.IsPlayerAlive())
            {
                while (_player.IsInVillage)
                {
                    Console.WriteLine();
                    Console.WriteLine("You stand at the entry of a village");
                    Console.WriteLine("If you turn back now you will be attacked");
                    Console.WriteLine();
                
                    _npcGameflow.PathDesciption();
                }
                _combatGameflow.StartCombat();
            }
        }

        public void SetupPlayer()
        {
            NamePlayer();
            _combatGameflow.AssignPlayer(_player);
        }

        public void NamePlayer()
        {
            string playerName = InputPlayerName();
            _player.Name = playerName;
        }
        
        public string InputPlayerName()
        {
            Console.Write("Enter your hero's name: ");
            return Console.ReadLine();
        }
        
        public void VillageEnterExit()
        {
            Console.WriteLine("Do you want to leave the village? (y/n)");
            string input = Console.ReadLine()?.ToLower();

            if (input == "y")
            {
                _player.IsInVillage = false;
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
    }
}