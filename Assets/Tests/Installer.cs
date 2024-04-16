using Zenject;

namespace Tests
{
    public class Installer : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<CallbacksTest>().AsSingle();
        }
    }
}