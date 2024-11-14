using Kata10Exam;
namespace Kata10Exam
{
    public class CombatantCreationLogic
    {
        public enum EnemyType
        {
            Troll,
            Orc,
            Goblin,
            Kobold
        }

        public static CombatSetup.Combatant CreateEnemy(EnemyType type, string name, int damage, int health)
        {
            switch (type)
            {
                case EnemyType.Troll:
                    return new CombatSetup.Enemy("Troll", 15, 100);
                
                case EnemyType.Orc:
                    return new CombatSetup.Enemy("Orc", 10, 50);
                
                case EnemyType.Goblin:
                    return new CombatSetup.Enemy("Goblin", 7, 30);
                
                case EnemyType.Kobold:
                    return new CombatSetup.Enemy("Kobold", 5, 20);
                
                default:
                    return new CombatSetup.Enemy("Slime", 5, 10);
            }
        }

        public static CombatSetup.Combatant CreatePlayer(string name, int damage, int health)
        {
            Console.Write("Enter your hero's name: ");
            name = Console.ReadLine();
            return new CombatSetup.Player(name, 10, 100);
        }
    }
}