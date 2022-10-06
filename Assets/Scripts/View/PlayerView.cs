using UnityEngine;
using UnityEngine.UI;

namespace Asteroids
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField]
        private Slider _healthSlider;

        public DamageProvider DamageProvider { get; private set; }

        public void DoLateUpdate()
        {
            DamageProvider = null;
        }

        public void SetHpNormalized(int hp)
        {
            _healthSlider.value = (_healthSlider.maxValue - _healthSlider.minValue) * hp;
        }

        private void OnCollisionEnter(Collision collision)
        {
            DamageProvider = collision.gameObject.GetComponent<DamageProvider>();
        }


    }
}