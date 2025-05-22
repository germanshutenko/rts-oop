using UnityEngine;

namespace RtsOop
{
    public class Spawner : ISpawner
    {
        private const string TankPath = "Tank";

        private IUnitRepository UnitRepository;
        private IResourceManager ResourceManager;

        public Spawner(IUnitRepository unitRepository, IResourceManager resourceManager)
        {
            UnitRepository = unitRepository;
            ResourceManager = resourceManager;
        }

        public IUnit SpawnTank(Vector3 position, Quaternion rotation)
        {
            var tankAsset = ResourceManager.GetAsset<BaseUnit>(TankPath);
            var tank = Object.Instantiate(tankAsset, position, rotation);

            UnitRepository.Add(tank);

            return tank;
        }
    }
}