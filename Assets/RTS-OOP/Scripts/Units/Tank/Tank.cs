namespace RtsOop
{
    public class Tank : BaseUnit
    {
        private void Awake()
        {
            UnitBehaviour = new TankBehaviour(this);
        }
    }
}