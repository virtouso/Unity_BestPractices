using BoxCollectorExample.Script.Model;
using MVC.MVC;
using UnityEngine;
using Zenject;

namespace BoxCollectorExample.Script.Controller
{
    public interface IStateController
    {
        void UpdateInput(Vector2 input);
        Vector2 GetInput();
        bool CanUseInput();
    }
    
    [System.Serializable]
    public class StateController :BaseController, IStateController
    {
        [Inject] private StateModel _stateModel;

        public void UpdateInput(Vector2 input)
        {
            _stateModel.ActiveInput = input;
        }

        public Vector2 GetInput()
        {
            return _stateModel.ActiveInput;
        }

        public bool CanUseInput()
        {
            return _stateModel.CurrentGameState == GameState.Playing;
        }
    }
}
