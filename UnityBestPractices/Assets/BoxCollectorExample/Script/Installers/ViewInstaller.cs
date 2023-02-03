using System;
using BoxCollectorExample.Script.View;
using UnityEngine;
using Zenject;

namespace BoxCollectorExample.Script.Installers
{
    public class ViewInstaller: MonoInstaller
    {
        [SerializeField] private FinalMessageView _finalMessageView;
        
        public override void InstallBindings()
        {
            Container.Bind<Canvas>().FromComponentInHierarchy().AsSingle();
            
            Container.Bind<IUiView>().To<UiView>().FromNewComponentOnNewGameObject().AsSingle();
            Container.Bind<IFinalMessageView>().To<FinalMessageView>().FromComponentInNewPrefab(_finalMessageView).AsSingle();
            Container.Bind<IInputView>().To<InputView>().FromNewComponentOnNewGameObject().AsSingle();

        }
    }
}