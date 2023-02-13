using System;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class ExampleServiceLocator : MonoBehaviour
    {
        [ContextMenu("Service Locator")]
        private void TestServiceLocator()
        {
            ServiceLocator.SetService<IService>(new NameManager());
        }
    }
}