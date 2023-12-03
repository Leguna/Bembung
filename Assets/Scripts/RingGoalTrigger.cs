using System.Collections;
using System.Collections.Generic;
using Base;
using UnityEngine;

public class RingGoalTrigger : MonoBehaviour
{
    [HideInInspector] public List<GameObject> ringObjects;
    private GameRunner _gameRunner;
    private Coroutine _addRingObjectCoroutine;

    private void Start() => _gameRunner = GameRunner.Instance;

    private IEnumerator UpdateScore()
    {
        yield return new WaitForSeconds(1f);
        _gameRunner.UpdateScore(ringObjects.Count);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(StringConst.RingTag) || !enabled) return;
        ringObjects.Add(other.transform.parent.gameObject);
        StartCoroutine(UpdateScore());
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag(StringConst.RingTag) || !enabled) return;
        ringObjects.Remove(other.transform.parent.gameObject);
        _gameRunner.UpdateScore(ringObjects.Count);
    }
}