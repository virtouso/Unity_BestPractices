using BestPractices;
using PlasticGui;
using UnityEngine;
using Zenject;

namespace BoxCollectorExample.Script.Installers
{
    public class ConfigurationInstaller: MonoInstaller
    {
        [SerializeField] private GeneralGameSettings _generalGameSettings;
        
        public override void InstallBindings()
        {
            Container.Bind<IGeneralGameSettings>().To<GeneralGameSettings>().FromScriptableObject(_generalGameSettings).AsSingle();

        }
    }
}