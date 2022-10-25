using System;
using UnityEngine;

namespace ObjectPool.Scripts
{
    public class ObjectPoolExample : MonoBehaviour
    {
        private SimplePool _simplePool;


        public void Init(GameObject pooledGameObject)
        {
            _simplePool = new SimplePool(pooledGameObject);
        }

        public void StartGame()
        {
            var obj = _simplePool.Get();

            _simplePool.Return(obj);
        }

        private void OnDestroy()
        {
            _simplePool.Dispose();
        }
    }
}