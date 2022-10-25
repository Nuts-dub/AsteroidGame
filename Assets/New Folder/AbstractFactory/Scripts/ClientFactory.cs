using Factory.Scripts.Enemies;
using Factory.Scripts.Players;

namespace AbstractFactory.Scripts
{
    public class ClientFactory : AbstractFactory
    {
        public override IEnemy CreateEnemy()
        {
            return new Enemy();
        }

        public override IPlayer CreatePlayer()
        {
            return new Player();
        }
    }
}