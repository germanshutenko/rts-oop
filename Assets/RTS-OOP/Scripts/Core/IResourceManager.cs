namespace RtsOop
{
    public interface IResourceManager
    {
        T GetAsset<T>(string path) where T : UnityEngine.Object;
    }
}