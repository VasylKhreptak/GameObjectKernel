using System;
using Plugins.GameObjectKernel.Events;
using UnityEngine;
using Zenject;

namespace Tests
{
    public class CallbacksTest : IInitializable, IEnableEventHandler, IDisableEventHandler, ITickable, IFixedTickable, ILateTickable,
        IDisposable
    {
        public void Initialize() => Debug.Log("Initialize");

        public void OnEnable() => Debug.Log("OnEnable");

        public void OnDisable() => Debug.Log("OnDisable");

        public void Tick() => Debug.Log("Tick");

        public void FixedTick() => Debug.Log("FixedTick");

        public void LateTick() => Debug.Log("LateTick");

        public void Dispose() => Debug.Log("Dispose");
    }
}