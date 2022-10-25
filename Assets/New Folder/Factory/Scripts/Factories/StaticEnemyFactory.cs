using Factory.Scripts.Enemies;

namespace Factory.Scripts.Factories
{
    public static class StaticEnemyFactory
    {
        public static Enemy CreateEnemy()
        {
            return new Enemy();
        }

        public static Enemy CreateEnemy(string type)
        {
            return new Enemy();
        }
    }
}