using UnityEngine;

namespace Asteroids
{
    public class GameStarter : MonoBehaviour
    {
        private void Start()
        {

            IEnemyFactory factory = new AsteroidFactory();

            Enemy.Factory = factory;
            Enemy.Factory.Create(new Health(100.0f, 100.0f));

            EnemyPool enemyPool = new EnemyPool(5);
            var enemy = enemyPool.GetEnemy("Asteroid");
            enemy.transform.position = Vector3.one;
            enemy.gameObject.SetActive(true);
        }
    }
}
