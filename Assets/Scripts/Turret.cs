using UnityEngine;

namespace Asteroids
{
    public class Turret : Enemy
    {
        [SerializeField] private Player _player;
        [SerializeField] private float _speedRotate;
        [SerializeField] private GameObject _bulletPrefab;
        [SerializeField] private Transform _spawnPosition;
        [SerializeField] private float _cooldown;
        [SerializeField] private bool _isFire;

        void FixedUpdate()
        {
            var direction = _player._transformPlayer.position - transform.position;
            var stepRotate = Vector3.RotateTowards(transform.forward,
                    direction,
                    _speedRotate * Time.fixedDeltaTime,
                    0f);
            Ray ray = new Ray(_spawnPosition.position, transform.forward);

            if (Physics.Raycast(ray, out RaycastHit hit, 6))
                if (hit.collider.CompareTag("Player"))
                {
                    if (_isFire)
                        Fire();
                    transform.rotation = Quaternion.LookRotation(stepRotate);
                }
        }

        private void Fire()
        {
            _isFire = false;
            var shieldObj = Instantiate(_bulletPrefab, _spawnPosition.position, _spawnPosition.rotation);
            var shield = shieldObj.GetComponent<Laser>();
            shield.Init(_player._transformPlayer, 10, 3f);

            Invoke(nameof(Reloading), _cooldown);
        }

        private void Reloading()
        {
            _isFire = true;
        }
    }
}