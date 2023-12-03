﻿using System.Collections;
using Base;
using UnityEngine;
using Utilities;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    public bool isGameplayStarted;
    public bool isGamePaused;

    private float _highestTime;
    public float gameTime;
    public float score;
    
    [Header("Timer")] public float countDownTime = 3;

    private GamePrefabs _gamePrefabs;

    private void Start()
    {
        _gamePrefabs = GamePrefabs.Instance;
        CountDownStart();
    }

    private void UpdateTimeUI(float timeInSecond)
    {
        var newTimeText = $"Time:\n{StringUtils.FormatTime(timeInSecond)}";
        _gamePrefabs.timerText.text = newTimeText;
        _gamePrefabs.gameOverTimeText.text = newTimeText;
    }

    private void Update()
    {
        if (!isGameplayStarted || isGamePaused) return;
        gameTime += Time.deltaTime;
        UpdateTimeUI(gameTime);
    }

    private void CountDownStart() => StartCoroutine(CountDown(3));

    private IEnumerator CountDown(float repeatCount)
    {
        for (var i = 0; i < repeatCount; i++)
        {
            _gamePrefabs.countDownText.gameObject.transform.localScale = Vector3.zero;
            LeanTween.scale(_gamePrefabs.countDownText.gameObject, new Vector3(1, 1, 1), 1f).setEaseLinear();
            yield return new WaitForSeconds(1);
            countDownTime -= 1;
            _gamePrefabs.countDownText.text = countDownTime.ToString("0");
            if (!(countDownTime <= 0)) continue;
            isGameplayStarted = true;
            _gamePrefabs.countDownText.text = "Game Start!";
            _gamePrefabs.countDownText.gameObject.transform.LeanScale(new Vector3(0, 0, 0), 1f);
        }
    }

    public void UpdateScore(float newScore)
    {
        score = newScore;
        var newScoreText = $"Fastest\n{_highestTime}";
        _gamePrefabs.scoreText.text = newScoreText;
        _gamePrefabs.gameOverScoreText.text = newScoreText;
        if (!GameCompleteCheck()) return;
        ShowScoreMenu();
        isGamePaused = true;
        isGameplayStarted = false;
    }


    private bool GameCompleteCheck() => (int)score == _gamePrefabs.ringSpawnPositionList.Count;

    private void ShowScoreMenu()
    {
        _gamePrefabs.gameplayUI.SetActive(false);
        _gamePrefabs.gameOverUI.SetActive(true);
    }
}