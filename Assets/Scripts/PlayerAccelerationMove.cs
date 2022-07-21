using UnityEngine;

namespace Asteroids
{
    internal sealed class PlayerAccelerationMove : PlayerMovement
    {
        private readonly float _acceleration;
        public PlayerAccelerationMove(Transform transform, float speed, float acceleration)
        : base(transform, speed)
        {
            _acceleration = acceleration;
        }
        public void AddAcceleration()
        {
            Speed += _acceleration;
        }
        public void RemoveAcceleration()
        {
            Speed -= _acceleration;
        }
    }
}
