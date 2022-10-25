using System;
using Factory.Scripts.Enemies;

namespace Factory.Scripts.Factories
{
    public class EnemyFactory
    {
        public Enemy CreateEnemy()
        {
            return new Enemy();
        }

        public IEnemy CreateEnemy(EnemyType enemyType)
        {
            switch (enemyType)
            {
                case EnemyType.Enemy:
                    return new Enemy();
                case EnemyType.Ranged:
                    return new RangedEnemy();
                case EnemyType.RangedWithCrossbow:
                    return new RangedEnemyWithCrossbow();
                case EnemyType.RangedWithLaser:
                    return new RangedEnemyWithLaser();
                case EnemyType.Melee:
                    return new MeleeEnemy();
                case EnemyType.MeleeWithSword:
                    return new MeleeEnemyWithSword();
                case EnemyType.WithoutView:
                    return new EnemyWithoutView();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}