using System;
using Factory.Scripts.Enemies;
using Factory.Scripts.Factories;
using UnityEngine;

namespace Factory.Scripts
{
    public class FactoryExample02 : MonoBehaviour
    {
        private EnemyFactory _enemyFactory;


        #region Dependency Injection

        public EnemyFactory EnemyFactory
        {
            set => _enemyFactory = value;
        }

        public void SetEnemyFactory(EnemyFactory enemyFactory)
        {
            _enemyFactory = enemyFactory;
        }

        // MonoBehaviour is NOT supposed to be created with a constructor
        // public FactoryExample(EnemyFactory enemyFactory)
        // {
        //     _enemyFactory = enemyFactory;
        // }

        #endregion


        private void StartComplexGameWithFactories()
        {
            if (_enemyFactory == null)
                throw new Exception("There is no factory for enemies");

            var enemy = _enemyFactory.CreateEnemy();

            var enemyWithSword = _enemyFactory.CreateEnemy(EnemyType.MeleeWithSword);

            var enemy1 = StaticEnemyFactory.CreateEnemy();
        }
    }
}