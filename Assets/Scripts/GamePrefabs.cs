﻿using System.Collections.Generic;
using Base;
using TMPro;
using UnityEngine;

public class GamePrefabs : SingletonMonoBehaviour<GamePrefabs>
{
    [Header("Gameplay")] public List<GameObject> ringList;
    public GameObject ringPrefab;
    public GameObject goalPrefab;
    public GameObject ringsParent;
    [HideInInspector] public List<Rigidbody> ringRigidbodyList;
    public List<GameObject> mechanicList;
    public List<GameObject> goalList;
    public List<GameObject> ringSpawnPositionList;

    [Header("UI")] public TMP_Text timerText;

}