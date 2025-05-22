using UnityEngine;

namespace RtsOop
{
    public class TankHealth : MonoBehaviour, IHealth
    {
        public float HealthPoints { get; private set; }

        private void Awake()
        {
            var unitComponents = GetComponentInParent<IUnitComponents>();
            unitComponents.SetHealth(this);
        }

        public void SetHealthPoints(float healthPoints)
        {
            HealthPoints = healthPoints;
        }

        public void TakeDamage(float damage)
        {
            HealthPoints -= damage;
        }
    }
}