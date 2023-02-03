using BoxCollectorExample.Script.Model;
using Zenject;

namespace BoxCollectorExample.Script.Installers
{
    public class ModelInstaller:MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<StateModel>().FromNew().AsSingle();
        }
    }
}