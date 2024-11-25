namespace ExamKata
{
    public class CombatGameflow
    {
        private bool _isPlayerTurn = true;
        private CombatantSetup.Player _player;
        private CombatantSetup.Enemy _enemy;

        private MasterGameflow _masterGameflow;

        public CombatGameflow(MasterGameflow masterGameflow)
        {
            _masterGameflow = masterGameflow;
        }

        public void InitializeEnemy()
        {
            _enemy = EnemyCreation.CreateRandomEnemy();
        }

        public void StartCombat()
        {
            InitializeEnemy();
            CombatLoop();
        }

        private void CombatLoop()
        {
            Console.WriteLine();
            Console.WriteLine($"A {_enemy.Name} blocks your way!");

            while (_player.Health > 0 && _enemy.Health > 0 && !_player.IsInVillage)
            {
                Console.WriteLine();
                Console.WriteLine($"{_player.Name} HP: {_player.Health}");
                Console.WriteLine($"{_enemy.Name} HP: {_enemy.Health}");
                Console.WriteLine();

                if (_isPlayerTurn)
                {
                    Thread.Sleep(1000);
                    PlayerTurn();
                    Console.WriteLine();
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    _enemy.Attack(_player);
                }
                _isPlayerTurn = !_isPlayerTurn;
            }
            BattleResult();
        }

        private void BattleResult()
        {
            if (_player.Health <= 0)
            {
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine($"The {_enemy.Name} managed to kill you!");
            }
            else if (_enemy.Health <= 0)
            {
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine($"You defeated the {_enemy.Name}!");
            }
        }

        private void PlayerTurn()
        {
            PlayerActionDescription();
            ActionChoice();
        }
        
        private void PlayerActionDescription()
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1 ---- Attack");
            Console.WriteLine("2 ---- Heal");
            Console.WriteLine("3 ---- Flee");
        }
        private void ActionChoice()
        {
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    _player.Attack(_enemy);
                    break;
                case "2":
                    _player.Heal(); 
                    break;
                case "3":
                    Console.WriteLine("You have succefully fled to the village");
                    _player.IsInVillage = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                    PlayerTurn();
                    break;
            }
        }

        public void AssignPlayer(CombatantSetup.Player player)
        {
            _player = player;
        }
    }
}