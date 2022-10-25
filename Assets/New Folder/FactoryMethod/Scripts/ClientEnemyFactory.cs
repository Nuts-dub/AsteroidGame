using Factory.Scripts.Enemies;

namespace FactoryMethod.Scripts
{
    public class ClientEnemyFactory : EnemyParentFactory
    {
        protected override IEnemy CreateEnemy()
        {
            IEnemy enemy = new Enemy();
            enemy.Attack();
            return enemy;
        }

        protected override void DoProtectedThingsWithEnemy(IEnemy enemy)
        {
            base.DoProtectedThingsWithEnemy(enemy);
        }
    }
}