using BoxCollectorExample.Script.Controller;
using Zenject;

namespace BoxCollectorExample.Script.Installers
{
    public class ControllerInstaller: MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IStateController>().To<StateController>().FromNew().AsSingle();
            
            
        }
    }
}