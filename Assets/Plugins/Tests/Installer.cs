using Plugins.GameObjectKernel;
using Zenject;

namespace Plugins.Tests
{
    public class Installer : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ToggleableManager>().AsSingle();
            Container.BindInterfacesTo<CallbacksTest>().AsSingle();
        }
    }
}