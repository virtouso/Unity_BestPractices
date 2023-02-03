using System;
using System.Collections;
using System.Collections.Generic;
using BoxCollectorExample.Script.App;
using UnityEngine;
using Zenject;

namespace BestPractices
{
    public class Application : MonoBehaviour
    {
        [Inject] private IViewBootstrapper _viewBootstrapper;
        [Inject] private IModelBootstrapper _modelBootstrapper;
        [Inject] private IControllerBootstrapper _controllerBootstrapper;
        
        private void Start()
        {
            
        }
    }
}
