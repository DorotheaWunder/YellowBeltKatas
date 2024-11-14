using Kata10Exam;
namespace Kata10Exam;


public class MasterGameflow
{
    private bool _isInVillage = true;
    private int _playerHealth = 100; //will probably need update
    private NpcInteraction _npcInteraction;
    
    //-----------------------------------------create player here??
    // public static CombatSetup.Combatant CreatePlayer(string name, int damage, int health)
    // {
    //     Console.Write("Enter your hero's name: ");
    //     name = Console.ReadLine();
    //     return new CombatSetup.Player(name, 10, 100);
    // }
    
    public MasterGameflow()
    {
        _npcInteraction = new NpcInteraction();
    }
    public bool IsPlayerAlive()
    {
        return _playerHealth > 0;
    }
    public void DetermineGameflow()
    {
        if (_isInVillage)
        {
            NpcGameflow npcGameflow = new NpcGameflow(_npcInteraction);
            npcGameflow.PathDesciption();
        }
        else
        {
            Console.WriteLine("You are in the wilderness where you're going to fight");
        }
    }
}