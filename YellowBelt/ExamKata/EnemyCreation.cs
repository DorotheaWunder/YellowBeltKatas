using ExamKata;
namespace ExamKata
{
    public class EnemyCreation
    {
        public enum EnemyType
        {
            Troll,
            Orc,
            Goblin,
            Kobold
        }
    
        public static CombatantSetup.Enemy CreateEnemy(EnemyType enemyType)
        {
            switch (enemyType)
            {
                case EnemyType.Troll:
                    return new CombatantSetup.Enemy("Troll", 20, 50);
                case EnemyType.Orc:
                    return new CombatantSetup.Enemy("Orc", 10, 50);
                case EnemyType.Goblin:
                    return new CombatantSetup.Enemy("Goblin", 5, 30);
                case EnemyType.Kobold:
                    return new CombatantSetup.Enemy("Kobold", 5, 10);
                default:
                    return new CombatantSetup.Enemy("Slime", 5, 5);
            }
        }
    
        public static CombatantSetup.Enemy CreateRandomEnemy()
        {
            Random random = new Random();
            Array enemyTypes = Enum.GetValues(typeof(EnemyType));
            EnemyType randomEnemy = (EnemyType)enemyTypes.GetValue(random.Next(enemyTypes.Length));
            return CreateEnemy(randomEnemy);
        }
    }
}

