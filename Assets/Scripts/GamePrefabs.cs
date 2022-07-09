using System.Collections.Generic;
using Base;
using TMPro;
using UnityEngine;

public class GamePrefabs : SingletonMonoBehaviour<GamePrefabs>
{
    [Header("Gameplay")] public List<GameObject> ringList;
    public List<Rigidbody> ringRigidbodyList;
    public List<GameObject> mechanicList;

    [Header("UI")] public TMP_Text timerText;

    protected override void Awake()
    {
        base.Awake();
        foreach (GameObject o in ringList)
        {
            o.TryGetComponent(out Rigidbody rb);
            ringRigidbodyList.Add(rb);
        }
    }
}