using Factory.Scripts.Enemies;
using Factory.Scripts.Players;

namespace AbstractFactory.Scripts
{
    public abstract class AbstractFactory
    {
        public abstract IEnemy CreateEnemy();
        public abstract IPlayer CreatePlayer();
    }
}