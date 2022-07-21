using UnityEngine;

namespace Asteroids
{
    public class PlayerController : PlayerView, IExecute
    {
        private float horizontal;
        private float vertical;
        private Ship _ship;

        public void Awake()
        {
            var moveTransform = new PlayerAccelerationMove(transform, _speed, _acceleration);
            var rotation = new PlayerRotation(transform);
            _ship = new Ship(moveTransform, rotation);
        }

        public void Update()
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _ship.AddAcceleration();
            }

            _ship.Move(horizontal, vertical, Time.deltaTime);


        }
    }
}