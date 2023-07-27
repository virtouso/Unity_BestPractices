using UnityEngine;

namespace BestPractices.EventBus
{
    public class ExamplesSignals:MonoBehaviour
    {
        private void Start()
        {
            EventDispatcher.Instance.DeclareSignal<Signal1>();
            EventDispatcher.Instance.DeclareSignal<Signal2>();
            EventDispatcher.Instance.DeclareSignal<Signal3>();
            EventDispatcher.Instance.DeclareSignal<Signal4>();
        }
        
    }



    public class Signal1
    {
        public string Data1 { get; set; }
    }

    public class Signal2
    {
        public string Data2 { get; set; }
    }

    public class Signal3
    {
        public string Data3 { get; set; }
    }

    public class Signal4
    {
        public string Data4 { get; set; }
    }
    
}