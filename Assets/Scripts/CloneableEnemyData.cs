using System;

namespace Asteroids
{
    public class CloneableEnemyData : ICloneable
    {
        public CloneableHealthData HealthData;
        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    public class CloneableHealthData
    {
        public int MaxHealth;
        public int CurrentHealth;
    }
}