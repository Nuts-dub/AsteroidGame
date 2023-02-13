using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class EnemyDataFactory
    {

        public static CloneableEnemyData CreateCloneableEnemyData()
        {
            var enemyData = new CloneableEnemyData() { HealthData = new CloneableHealthData { MaxHealth = 100, CurrentHealth = 99 } };
            return enemyData;
        }
    }
}