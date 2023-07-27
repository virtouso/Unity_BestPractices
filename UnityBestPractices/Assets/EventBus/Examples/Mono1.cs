using System;
using System.Threading.Tasks;
using UnityEngine;

namespace BestPractices.EventBus.Examples
{
    public class Mono1:MonoBehaviour
    {
        private async void Start()
        {
            await Task.Delay(3000);
            EventDispatcher.Instance.Fire<Signal1>(new Signal1{Data1 = "mono1 sent signal1"});
        }
        
        
        
        
    }
}