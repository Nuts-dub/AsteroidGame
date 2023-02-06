using UnityEngine;

namespace Asteroids
{
    public sealed class Asteroid : Enemy
    {
        [SerializeField] private float _damage = 3;

        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Explosion(Collision collision)
        {
            if (collision.gameObject.TryGetComponent(out ITakeDamage takeDamage))
            {
                Debug.Log("Hit!");
                takeDamage.Hit(_damage);
                Destroy(gameObject);
            }
        }
    }
}