namespace RtsOop
{
    public interface IHealth
    {
        float HealthPoints { get; }

        void SetHealthPoints(float healthPoints);
        void TakeDamage(float damage);
    }
}