using UnityEngine;

namespace Asteroids
{
    public class PlayerHealth : PlayerView ,ITakeDamage
    {
        public void damage()
        {

        }
        public void Hit(float damage)
        {
            _health -= damage;

            if (_health <= 0)
            {
                Debug.Log("Game Over");
            }
        }
    }
}