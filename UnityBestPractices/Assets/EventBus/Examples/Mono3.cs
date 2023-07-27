using UnityEngine;

namespace BestPractices.EventBus.Examples
{
    public class Mono3:MonoBehaviour
    {
        public void ShowSignal1(Signal1 signal)
        {
            Debug.Log($"{this.GetType().Name} received:{signal.Data1}");
        }
        
        private void Start()
        {
            EventDispatcher.Instance.Subscribe<Signal1>(ShowSignal1);
        //    EventDispatcher.Instance.UnSubscribe<Signal1>(ShowSignal1);
        }
    }
}