using BoxCollectorExample.Script.Model;
using UnityEngine;
using Zenject;

namespace BoxCollectorExample.Script.App
{
    
    public interface  IModelBootstrapper{}
    
    public class ModelBootstrapper : MonoBehaviour, IModelBootstrapper
    {
        [Inject][SerializeField] private StateModel _stateModel;

    }
}
