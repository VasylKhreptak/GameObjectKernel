using Zenject;

namespace Plugins.GameObjectKernel
{
    public class Kernel : MonoKernel
    {
        private ToggleableManager _toggleableManager;

        [Inject]
        private void Constructor(ToggleableManager toggleableManager)
        {
            _toggleableManager = toggleableManager;
        }

        #region MonoBehaviour

        private void OnEnable()
        {
            if (HasInitialized == false)
                return;

            _toggleableManager.Enable();
        }

        private void OnDisable() => _toggleableManager.Disable();

        #endregion

        protected override void OnAfterInitialize() => _toggleableManager.Enable();
    }
}