using UnityEngine;

namespace Asteroids
{
    internal sealed class AsteroidFactory
    {
        public static Enemy Create(Health hp)
        {
            var enemy = Object.Instantiate(Resources.Load<Asteroid>("Enemy/Asteroid"));
            enemy.DependencyInjectHealth(hp);
            return enemy;
        }
    }
}