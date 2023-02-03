using System;
using BoxCollectorExample.Script.View;
using MVC.MVC;
using UnityEngine;
using Zenject;

namespace BoxCollectorExample.Script.App
{
    public interface IViewBootstrapper
    {
    }

    public class ViewBootstrapper : BaseView, IViewBootstrapper
    {
        [Inject] private Canvas _canvas;
        
        [Inject] private IUiView _uiView;
        [Inject] private IInputView _inputView;
        
        [Inject] private IFinalMessageView _finalMessageView;


        private void Start()
        {
            (_inputView as BaseView).SetParent(this.transform);
            (_uiView as BaseView).SetParent(this.transform);
            (_finalMessageView as BaseView).SetParent(_canvas.transform);
        }
    }
}