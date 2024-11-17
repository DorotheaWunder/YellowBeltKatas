namespace ExamKata
{
    class ExamKata
    {
        public static void Main()
        {
            // NpcGameflow npcGameflow = new NpcGameflow(new NpcInteraction(), new MasterGameflow(null, null));  
            // CombatGameflow combatGameflow = new CombatGameflow();
            
            MasterGameflow masterGameflow = new MasterGameflow();
            
            masterGameflow.RunGame();
        }
    }
}


