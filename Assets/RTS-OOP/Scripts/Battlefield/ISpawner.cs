using UnityEngine;

namespace RtsOop
{
    public interface ISpawner
    {
        IUnit SpawnTank(Vector3 position, Quaternion rotation);
    }
}