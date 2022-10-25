using Factory.Scripts.Enemies;

namespace FactoryMethod.Scripts
{
    public abstract class EnemyParentFactory
    {
        // Factory Method
        public IEnemy GetEnemy()
        {
            var enemy = CreateEnemy();

            DoPrivateThingsWithEnemy(enemy);
            DoProtectedThingsWithEnemy(enemy);
            
            return enemy;
        }

        protected abstract IEnemy CreateEnemy();


        #region Other methods to do stuff with created enemies

        private void DoPrivateThingsWithEnemy(IEnemy enemy)
        {
        }
        
        protected virtual void DoProtectedThingsWithEnemy(IEnemy enemy)
        {
        }

        #endregion
    }
}