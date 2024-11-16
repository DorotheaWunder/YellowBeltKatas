using Kata10Exam;
namespace Kata10Exam;

public class MasterGameflow
{
    private bool _isInVillage;
    CombatGameflow combatGameflow = new();

    public void InitializeCombat()
    {
        combatGameflow.InitializeCombat();
    }
    public void DetermineGameflow()
    {
        if (_isInVillage)
        {
            Console.WriteLine("you are in the village");
        }
        else
        {
            combatGameflow.InitializeCombat();
        }
    }
}