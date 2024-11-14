namespace Kata10Exam;


class ProgramExamKata10
{
    
    public static void Main()
    {
        //maybe enter player name here?
        MasterGameflow gameflow = new MasterGameflow();
        while (gameflow.IsPlayerAlive())
        {
            gameflow.DetermineGameflow();
            Console.WriteLine();
        }
        Console.WriteLine("You have been defeated");
        Console.WriteLine("GAME OVER");
    }
}



//while playerhealth > 0; do turn ourder of everythin