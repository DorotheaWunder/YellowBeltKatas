using Kata10Exam;
namespace Kata10Exam;

public class CombatGameflow
{
    private bool _isPlayerTurn;
    private CombatantSetup.Player _player;
    private CombatantSetup.Enemy _enemy; 

    public void CreatePlayer()
    {
        Console.Write("Enter your hero's name: ");
        string playerName = Console.ReadLine();
        _player = new CombatantSetup.Player(playerName, 10, 100, 20);
    }

    public void InitializeFighters()
    {
        CreatePlayer();
        _enemy = EnemyCreation.CreateRandomEnemy();
    }

    public void InitializeCombat()
    {
        InitializeFighters();
        TurnOrder();
    }
    public void TurnOrder()
    {
        while (_player.Health > 0 && _enemy.Health > 0)
        {
            if (_isPlayerTurn)
            {
                PlayerActionDescription();
            }
            else
            {
                _enemy.Attack(_player);
            }
            _isPlayerTurn = !_isPlayerTurn;
        }
        if (_player.Health <= 0)
        {
            Console.WriteLine($"The {_enemy.Name} managed to kill you!");
        }
        else if (_enemy.Health <= 0)
        {
            Console.WriteLine($"You defeated the {_enemy.Name}!");
        }
    }
    
    public void PlayerActionDescription()
    {
        Console.WriteLine($"Player HP: {_player.Health}");
        Console.WriteLine($"Enemy HP: {_enemy.Health}");
        Console.WriteLine("Choose an action:");
        Console.WriteLine("1 ---- Attack");
        Console.WriteLine("2 ---- Heal");
        Console.WriteLine("3 ---- Flee back to village");
        
        ActionChoice();
    }
    public void ActionChoice()
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
                Console.WriteLine("You decide to flee back to the village.");
                //-would set isinvillage to false
                break;
            default:
                Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                break;
        }
    }
}