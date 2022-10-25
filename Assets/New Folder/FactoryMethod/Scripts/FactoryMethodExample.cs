using UnityEngine;

namespace FactoryMethod.Scripts
{
    public class FactoryMethodExample : MonoBehaviour
    {
        private EnemyParentFactory _enemyFactory;

        public void StartGame()
        {
            var enemy = _enemyFactory.GetEnemy();
        }
    }
}