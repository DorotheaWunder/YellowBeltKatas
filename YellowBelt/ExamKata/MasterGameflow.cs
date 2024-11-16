using ExamKata;
namespace ExamKata
{
    public class MasterGameflow
    {
        private bool _isInVillage;
        private CombatGameflow _combatGameflow;
        private NpcGameflow _npcGameflow;

        public MasterGameflow(NpcGameflow npcGameflow, CombatGameflow combatGameflow)
        {
            _npcGameflow = npcGameflow;
            _combatGameflow = combatGameflow;
            _isInVillage = false;
        }

        public void DetermineGameflow()
        {
            if (_isInVillage)
            {
                Console.WriteLine("You stand at the entry of a village");
                Console.WriteLine("If you turn back now you will be attacked");
                _npcGameflow.PathDesciption();
            }
            else
            {
                _combatGameflow.InitializeCombat();
            }
        }

        public void InitializeCombat() //--------------------maybe in combat gameflow
        {
            _combatGameflow.InitializeCombat();
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
    }
}

