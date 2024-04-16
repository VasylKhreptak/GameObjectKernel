using System;
using Plugins.GameObjectKernel.Events;
using UnityEngine;
using Zenject;

namespace Tests
{
    public class CallbacksTest : IInitializable, IEnableEventHandler, IDisableEventHandler, IDisposable
    {
        public void Initialize() => Debug.Log("Initialize");

        public void OnEnable() => Debug.Log("OnEnable");

        public void OnDisable() => Debug.Log("OnDisable");

        public void Dispose() => Debug.Log("Dispose");
    }
}