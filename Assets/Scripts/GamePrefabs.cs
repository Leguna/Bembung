using System.Collections.Generic;
using UnityEngine;

public class GamePrefabs : SingletonMonoBehaviour<GamePrefabs>
{
    [Header("Gameplay")]
    public List<GameObject> ringList;
    public List<GameObject> mechanicList;

    [Header("UI")] public TMPro.TMP_Text timerText;
}