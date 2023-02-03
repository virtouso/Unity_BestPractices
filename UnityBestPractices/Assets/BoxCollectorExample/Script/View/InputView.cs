using System;
using BoxCollectorExample.Script.Controller;
using MVC.MVC;
using UnityEngine;
using Zenject;

namespace BoxCollectorExample.Script.View
{
    public interface IInputView{}
    public class InputView: BaseView, IInputView
    {

        [Inject] private IStateController _stateController;

        private void Update()
        {

            float horizontal = UnityEngine.Input.GetAxis("Horizontal");
            float vertical = UnityEngine.Input.GetAxis("Vertical");
            _stateController.UpdateInput(new Vector2(horizontal,vertical));
            
        }
    }
}