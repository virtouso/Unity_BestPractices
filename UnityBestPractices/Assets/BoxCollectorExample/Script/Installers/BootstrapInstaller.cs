using BoxCollectorExample.Script.App;
using Zenject;

namespace BoxCollectorExample.Script.Installers
{
    public class BootstrapInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IViewBootstrapper>().To<ViewBootstrapper>().FromNewComponentOnNewGameObject().AsSingle();
            Container.Bind<IModelBootstrapper>().To<ModelBootstrapper>().FromNewComponentOnNewGameObject().AsSingle();
            Container.Bind<IControllerBootstrapper>().To<ControllerBootstrapper>().FromNewComponentOnNewGameObject().AsSingle();
        }
    }
}