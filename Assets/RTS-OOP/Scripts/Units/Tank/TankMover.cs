using UnityEngine;

namespace RtsOop
{
    public class TankMover : MonoBehaviour, IMover
    {
        public Vector3 MovementVector { get; private set; }

        private void Awake()
        {
            var unitComponents = GetComponentInParent<IUnitComponents>();
            unitComponents.SetMover(this);
        }

        public void SetMovementVector(Vector3 vector)
        {
            MovementVector = vector.normalized;
        }

        public void Move(float deltaTime)
        {
            var rotation = Quaternion.AngleAxis(-45f * deltaTime, Vector3.up);
            MovementVector = rotation * MovementVector;

            var newPosition = transform.position + MovementVector * deltaTime;
            transform.position = newPosition;
            transform.rotation = Quaternion.LookRotation(MovementVector);
        }
    }
}