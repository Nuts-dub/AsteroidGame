using Factory.Scripts.Enemies;
using Factory.Scripts.Players;

namespace AbstractFactory.Scripts
{
    public class ServerFactory : AbstractFactory
    {
        public override IEnemy CreateEnemy()
        {
            return new RangedEnemy();
        }

        public override IPlayer CreatePlayer()
        {
            return new Player();
        }
    }
}