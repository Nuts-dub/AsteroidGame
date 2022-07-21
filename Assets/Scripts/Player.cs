using UnityEngine;

namespace Asteroids
{
    internal sealed class Player : PlayerView
    {
        private Camera _camera;
        private Ship _ship;

        public void Start()
        {
            _camera = Camera.main;
        }

        public void Update()
        {
            var direction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
            _ship.Rotation(direction);
        }
    }
}