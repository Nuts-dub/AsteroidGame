using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
    public int NormalizeHP { get { return CurrentHp / MaxHp; } }
    public bool IsHpChanged { get; private set; }

    private int CurrentHp { get; set; }
    private int MaxHp { get; set; }

    public float _speed { get; set; }
    public float _acceleration { get; set; }
    public Transform _transform { get; set; }

    public PlayerModel(int maxHp)
    {
        MaxHp = maxHp;
        CurrentHp = maxHp;
    }

    public void LateUpdate()
    {
        IsHpChanged = false;
    }

    public void RaceiveDamage(int damage)
    {
        CurrentHp = CurrentHp - damage;
        IsHpChanged = true;
    }
}
