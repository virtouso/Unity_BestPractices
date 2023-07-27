using System;
using System.Collections.Generic;
using UnityEngine;

namespace BestPractices.EventBus
{
    public class EventDispatcher
    {
        private static EventDispatcher instance;

        public static EventDispatcher Instance
        {
            get
            {
                if (instance == null)
                    instance = new EventDispatcher();

                return instance;
            }
        }


        private Dictionary<Type, Dictionary<object, EventReference<object>>> signals { get; } = new();


        public void DeclareSignal<T>()
        {
            signals.Add(typeof(T), new Dictionary<object, EventReference<object>>());
        }

        public void Subscribe<T>(Action<T> action)
        {
            if (signals[typeof(T)].ContainsKey(action.Target))
            {
                Debug.Log("object already has a subscriber to the the type");
                return;
            }
            
            signals[typeof(T)].Add(action.Target,new EventReference<object>(ConvertAction(action),action.Method.Name,action.Target));
        }

        public void UnSubscribe<T>(Action<T> subscribedMethod)
        {
            if (!signals.ContainsKey(typeof(T)))
            {
                Debug.Log("type is not declared");
                return;
            }

            if (!signals[typeof(T)].ContainsKey(subscribedMethod.Target))
            {
                Debug.Log("object has no subscriber to remove");
                return;
            }
            
            signals[typeof(T)].Remove(subscribedMethod.Target);
        }

        public void Fire<T>(T message)
        {
            if (!signals.ContainsKey(typeof(T)))
            {
                Debug.Log("signal not declared");
                return;
            }

            if (signals[typeof(T)].Count <= 0)
            {
                Debug.Log("type has no subscriber");
                return;
            }


            foreach (var item in signals[typeof(T)])
            {
                item.Value.Action.Invoke(message);
            }
        }


        private Action<object> ConvertAction<T>(Action<T> myActionT)
        {
            if (myActionT == null) return null;
            else return new Action<object>(o => myActionT((T)o));
        }
    }


    public class EventReference<T>
    {
        public EventReference(Action<T> action, string methodName, object classReference)
        {
            Action = action;
            MethodName = methodName;
            ClassReference = classReference;
      
        }

        public Action<T> Action { get; }
  
        public string MethodName { get; }
        public object ClassReference { get; }
    }
}