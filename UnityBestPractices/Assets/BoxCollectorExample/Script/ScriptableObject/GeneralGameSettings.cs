using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BestPractices
{

    public interface IGeneralGameSettings
    {
        int MaxBallsHitToWin { get; }
    }
    public class GeneralGameSettings :ScriptableObject, IGeneralGameSettings
    {
        [SerializeField] private int _maxBallHiitToWin;
        public int MaxBallsHitToWin => _maxBallHiitToWin;
    }
}
