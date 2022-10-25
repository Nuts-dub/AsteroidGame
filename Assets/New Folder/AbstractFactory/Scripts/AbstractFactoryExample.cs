using Factory.Scripts.Enemies;
using Factory.Scripts.Players;
using UnityEngine;

namespace AbstractFactory.Scripts
{
    public class AbstractFactoryExample : MonoBehaviour
    {
        private AbstractFactory _clientFactory = new ClientFactory();

        private AbstractFactory _serverFactory = new ServerFactory();


        private void StartGame()
        {
            IEnemy enemy1 = _clientFactory.CreateEnemy();
            IPlayer player1 = _clientFactory.CreatePlayer();

            IEnemy enemy2 = _serverFactory.CreateEnemy();
            IPlayer player2 = _serverFactory.CreatePlayer();
        }
    }
}