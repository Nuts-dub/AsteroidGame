using UnityEngine;

namespace Asteroids
{
    public class PlayerController : IExecute
    {
        private PlayerModel PlayerModel { get; set; }
        private PlayerView PlayerView { get; set; }

        private float horizontal;
        private float vertical;
        private Ship _ship;

        public PlayerController(PlayerModel playerModel, PlayerView playerView)
        {
            PlayerModel = playerModel;
            PlayerView = playerView;
        }

        public void Awake()
        {
            var moveTransform = new PlayerAccelerationMove(PlayerModel._transform, PlayerModel._speed, PlayerModel._acceleration);
            var rotation = new PlayerRotation(PlayerModel._transform);
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

            if (PlayerView.DamageProvider != null)
                PlayerModel.RaceiveDamage(PlayerView.DamageProvider.damage);

            if (PlayerModel.IsHpChanged)
                PlayerView.SetHpNormalized(PlayerModel.NormalizeHP);
        }

        public void LateUpdate()
        {
            PlayerModel.LateUpdate();
            PlayerView.DoLateUpdate();
        }
    }
}