using BoxCollectorExample.Script.Controller;
using UnityEngine;
using Zenject;

namespace BoxCollectorExample.Script.App
{
    public interface IControllerBootstrapper
    {
    }

    public class ControllerBootstrapper : MonoBehaviour, IControllerBootstrapper
    {
        [Inject]  [SerializeField, SerializeReference] private IStateController _stateController;


    }
}