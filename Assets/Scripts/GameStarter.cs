using UnityEngine;

namespace Asteroids
{
    public class GameStarter : MonoBehaviour
    {

       // private IEnemyFactory factory = new AsteroidFactory();

        private void Start()
        {
            //Enemy.CreateAsteroidEnemy(new Health(100.0f, 100.0f));

            //factory.Create(new Health(100.0f, 100.0f));

            AsteroidFactory.Create(new Health(100.0f, 100.0f));

            //Enemy.Factory = factory;

            //factory.Create(new Health(100.0f, 100.0f));

            EnemyPool enemyPool = new EnemyPool(5);
            var enemy = enemyPool.GetEnemy("Asteroid");
            enemy.transform.position = Vector3.one;
            enemy.gameObject.SetActive(true);
        }
    }
}
