using Kata10Exam;
namespace Kata10Exam;

public class CombatGameflow
{
    //bool is player turn or not? -----belongs here? I suppose
    //while loop - while enemy has more than 0 hp?
    
    //as long as the player is outside of the village, they will encounter random enemies
    //player can go to village
    
    //also: do I need enemy creation logic?????
    
    public void PlayerCombatChoice()
    {
        //enemy info
        Console.WriteLine($"Enemy info ");
        Console.WriteLine("Choose an action:");
        Console.WriteLine("1 ---- Attack");
        Console.WriteLine("2 ---- Heal");
        Console.WriteLine("3 ---- Flee back to village");
        //flee (go back to area choice)
    }
}