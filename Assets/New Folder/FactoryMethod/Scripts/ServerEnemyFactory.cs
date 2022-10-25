using Factory.Scripts.Enemies;

namespace FactoryMethod.Scripts
{
    public class ServerEnemyFactory : EnemyParentFactory
    {
        protected override IEnemy CreateEnemy()
        {
            IEnemy enemy = new EnemyWithoutView();
            enemy.Attack();
            return enemy;
        }
    }
}