using MVC.MVC;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace BoxCollectorExample.Script.View
{
    
    public interface IUiView{}
    public class UiView: BaseView,IUiView
    {

        [SerializeField] private TextMeshPro _scoreText;

        
        

    }
}