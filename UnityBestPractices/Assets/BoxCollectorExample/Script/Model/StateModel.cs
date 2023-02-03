using UnityEngine;

namespace BoxCollectorExample.Script.Model
{
    [System.Serializable]
    public class StateModel
    {
        public Vector2 ActiveInput;
        public GameState CurrentGameState;
        
    }


    public enum GameState
    {
        Preparation,
        Playing,
        Finish
    }
    
}