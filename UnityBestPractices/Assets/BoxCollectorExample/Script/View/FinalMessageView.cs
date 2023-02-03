using System;
using MVC.MVC;
using TMPro;
using UnityEngine;

namespace BoxCollectorExample.Script.View
{
    public interface IFinalMessageView{}
    
    public class FinalMessageView: BaseView, IFinalMessageView
    {
        [SerializeField] private TextMeshPro _text;
        
        private void Start()
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}