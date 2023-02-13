using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class PrototypeExample : MonoBehaviour
    {
        [SerializeField]

        [ContextMenu("Dot Net Cloneable")]
        private void DotNetCloneable()
        {
            var origin = EnemyDataFactory.CreateCloneableEnemyData();
            var clone = (CloneableEnemyData)origin.Clone();

            origin.HealthData.CurrentHealth = 37;

            Debug.Log($"PrototypeExample.DotNetCloneable: origin.CurrentHealth = {origin.HealthData.CurrentHealth}; clone.CurrentHealth = {clone.HealthData.CurrentHealth}");
        }
    }
}