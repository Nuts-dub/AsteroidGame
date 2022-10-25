using Factory.Scripts.Enemies;
using Factory.Scripts.Factories;
using Factory.Scripts.Players;
using UnityEngine;

namespace Factory.Scripts
{
    public class FactoryExample01 : MonoBehaviour
    {
        private void StartSimpleGame()
        {
            var player = new Player();
            Enemy enemy = new Enemy();

            // Play the game
        }

        private void StartComplexGame()
        {
            var player = new Player();
            var enemy1 = new Enemy();
            var enemy2 = new RangedEnemyWithCrossbow();
            var enemy3 = new RangedEnemy();

            // Play the game

            var enemy4 = new MeleeEnemyWithSword();
        }

        class Level
        {
            public void StartNewLevel()
            {
                var enemy = new Enemy();
            }
        }
    }
}