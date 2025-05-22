using UnityEngine;

namespace RtsOop
{
    public abstract class BaseUnit : MonoBehaviour, IUnit, IUnitComponents
    {
        public IMover Mover { get; private set; }
        public IHealth Health { get; private set; }

        protected IUnitBehaviour UnitBehaviour;

        public void SetHealth(IHealth health)
        {
            Health = health;
        }

        public void SetMover(IMover mover)
        {
            Mover = mover;
        }

        private void Update()
        {
            UnitBehaviour.Update(Time.deltaTime);
        }

        public void Run()
        {
            Mover.SetMovementVector(transform.forward);
            UnitBehaviour.Run();
        }

        public void Stop()
        {
            UnitBehaviour.Stop();
        }
    }
}