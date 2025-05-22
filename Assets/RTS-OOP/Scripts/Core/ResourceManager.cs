using System.Collections.Generic;
using UnityEngine;

namespace RtsOop
{
    public class ResourceManager : IResourceManager
    {
        private Dictionary<string, Object> LoadedAssets = new Dictionary<string, Object>();

        public T GetAsset<T>(string path) where T : Object
        {
            if (LoadedAssets.ContainsKey(path))
            {
                return LoadedAssets[path] as T;
            }
            
            var asset = Resources.Load<T>(path);

            if (asset != null)
            {
                LoadedAssets.Add(path, asset);
                return asset;
            }
            else
            {
                Debug.LogError($"Asset not found at path: {path}");
                return null;
            }
        }
    }
}