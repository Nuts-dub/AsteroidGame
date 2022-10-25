using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace ObjectPool.Scripts
{
    public class SimplePool : IDisposable
    {
        // Generics
        // PoolSize, expanding or not
        // Parent
        
        private readonly Stack<GameObject> _pool = new Stack<GameObject>();
        private readonly GameObject _prefab;


        public SimplePool(GameObject prefab, int initialCount = 0)
        {
            _prefab = prefab;

            for (var i = 0; i < initialCount; i++)
            {
                Get();
            }
        }

        public GameObject Get()
        {
            GameObject result = (_pool.Count == 0) ? GameObject.Instantiate(_prefab) : _pool.Pop();
            /*
            GameObject result;
            if (_pool.Count == 0)
            {
                result = GameObject.Instantiate(_prefab);
            }
            else
            {
                result = _pool.Pop();
            }
            */

            // Do stuff with new game object when enabling
            // gameObject.SetActive(true);

            return result;
        }

        public void Return(GameObject gameObject)
        {
            // Do stuff before disabling
            // gameObject.SetActive(false);

            _pool.Push(gameObject);
        }

        public void Dispose()
        {
            foreach (var gameObject in _pool)
            {
                Object.Destroy(gameObject);
            }

            _pool.Clear();
        }
    }
}