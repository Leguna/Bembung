using Base;
using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    public bool isGameplayStarted = false;
    public bool isGamePaused = false;
    
    [Header("Timer")]
    public float timer;
    public bool gameplayStartCountdown;

}