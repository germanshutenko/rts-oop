namespace RtsOop
{
    public interface IUnitComponents
    {
        IMover Mover { get; }
        IHealth Health { get; }

        void SetMover(IMover mover);
        void SetHealth(IHealth health);
    }
}