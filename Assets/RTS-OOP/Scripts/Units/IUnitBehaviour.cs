namespace RtsOop
{
    public interface IUnitBehaviour
    {
        void Run();
        void Stop();
        void Update(float deltaTime);
    }
}