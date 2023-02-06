using UnityEngine;

namespace Asteroids
{
    internal sealed class Player : IExecute
    {
        private Camera _camera;
        private Ship _ship;
        public Transform _transformPlayer;

        public void Awake()
        {
            PlayerView playerView = new PlayerView();

            _camera = Camera.main;
            _transformPlayer = playerView.transform;
        }

        public void Update()
        {
            var direction = Input.mousePosition - _camera.WorldToScreenPoint(_transformPlayer.position);
            _ship.Rotation(direction);
        }
    }
}