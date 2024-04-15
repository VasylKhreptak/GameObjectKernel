using System.Collections.Generic;
using Plugins.GameObjectKernel.Events;
using Zenject;

namespace Plugins.GameObjectKernel
{
    public class ToggleableManager
    {
        [Inject(Optional = true, Source = InjectSources.Local)]
        private readonly List<IEnableEventHandler> _enableEventHandlers = new List<IEnableEventHandler>();

        [Inject(Optional = true, Source = InjectSources.Local)]
        private readonly List<IDisableEventHandler> _disableEventHandlers = new List<IDisableEventHandler>();

        private bool _isEnabled;

        public void Enable()
        {
            if (_isEnabled)
                return;

            foreach (IEnableEventHandler enableEventHandler in _enableEventHandlers)
                enableEventHandler.OnEnable();

            _isEnabled = true;
        }

        public void Disable()
        {
            if (_isEnabled == false)
                return;

            foreach (IDisableEventHandler disableable in _disableEventHandlers)
                disableable.OnDisable();

            _isEnabled = false;
        }
    }
}