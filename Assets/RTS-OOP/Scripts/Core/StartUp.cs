using UnityEngine;

namespace RtsOop
{
    public class StartUp : MonoBehaviour
    {
        private const int TankCount = 10000;

        private void Awake()
        {
            var spawner = CompositionRoot.GetSpawner();

            for (var i = 0; i < TankCount; i++)
            {
                var forward = Random.insideUnitCircle.normalized;
                var forward3D = new Vector3(forward.x, 0, forward.y);
                var position = Random.insideUnitSphere * 20f;
                position.y = 0f;

                var tank = spawner.SpawnTank(position, Quaternion.LookRotation(forward3D));
                tank.Run();
            }
        }
    }
}