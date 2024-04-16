using System.Collections.Generic;
using Plugins.GameObjectKernel.Events;
using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

namespace Tests
{
    public class LocalInjectTest : MonoBehaviour
    {
        [Inject(Optional = true, Source = InjectSources.Local)]
        private readonly List<IEnableEventHandler> _enableEventHandlers = new List<IEnableEventHandler>();

        [Inject(Optional = true, Source = InjectSources.Local)]
        private readonly List<IDisableEventHandler> _disableEventHandlers = new List<IDisableEventHandler>();
        
        [Button]
        private void Enable()
        {
            foreach (IEnableEventHandler enableEventHandler in _enableEventHandlers)
                enableEventHandler.OnEnable();
        }

        [Button]
        private void Disable()
        {
            foreach (IDisableEventHandler disableable in _disableEventHandlers)
                disableable.OnDisable();
        }
    }
}