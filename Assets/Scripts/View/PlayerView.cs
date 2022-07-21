using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField] public Rigidbody2D _player;
    [SerializeField] public float _speed;
    [SerializeField] public float _acceleration;
    [SerializeField] public float _health;
    [SerializeField] public Rigidbody2D _bullet;
    [SerializeField] public Transform _barrel;
    [SerializeField] public float _force;
    public Transform _transform;
}
