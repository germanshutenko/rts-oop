using UnityEngine;

namespace RtsOop
{
    public interface IMover
    {
        void SetMovementVector(Vector3 vector);
        void Move(float deltaTime);
    }
}