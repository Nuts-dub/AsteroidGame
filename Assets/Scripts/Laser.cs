using UnityEngine;

namespace Asteroids
{
    public class Laser : MonoBehaviour
    {
        [SerializeField] private float _damage = 3;
        [SerializeField] private float _force = 3;
        private Transform _target;
        private float _speed;
        private Rigidbody _rigidbody;

        public void Init(Transform target, float lifeTime, float speed)
        {
            _target = target;
            _speed = speed;
            Destroy(gameObject, lifeTime);

            _rigidbody.AddForce(transform.forward * _force);
        }
    }
}