using System.Collections;
using Base;
using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    public bool isGameplayStarted = false;
    public bool isGamePaused = false;

    [Header("Timer")] public float timer = 3;

    private void Start()
    {
        TimelineStart();
        CountDownStart();
    }

    private void TimelineStart()
    {
        
    }

    private void CountDownStart()
    {
        StartCoroutine(CountDown(3));
    }

    private IEnumerator CountDown(float repeatCount)
    {
        for (int i = 0; i < repeatCount; i++)
        {
            yield return new WaitForSeconds(1);
            timer -= 1;
            if (timer <= 0)
            {
                isGameplayStarted = true;
            }
        }
    }
}