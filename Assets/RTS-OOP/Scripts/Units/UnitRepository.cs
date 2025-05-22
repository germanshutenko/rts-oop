using System.Collections.Generic;

namespace RtsOop
{
    public class UnitRepository : IUnitRepository
    {
        private List<IUnit> Units = new List<IUnit>();

        public void Add(IUnit unit)
        {
            Units.Add(unit);
        }

        public void Remove(IUnit unit)
        {
            Units.Remove(unit);
        }
    }
}