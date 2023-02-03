using System.Net;
using UnityEngine;
using Zenject;

namespace MVC.MVC
{
    public abstract class BaseView : MonoBehaviour

    {
        [Inject] private SignalBus _signalBus;


        public void SetParent(Transform parent = null)
        {
            if (parent == null) return;
            transform.SetParent(parent);
        }
    }
}