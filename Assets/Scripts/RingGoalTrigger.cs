using System.Collections.Generic;
using Base;
using Base.Constant;
using UnityEngine;
using UnityEngine.Events;

public class RingGoalTrigger : MonoBehaviour
{
    [HideInInspector] public List<GameObject> ringObjects;
    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = GameManager.Instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(StringConst.RingTag) && enabled)
        {
            ringObjects.Add(other.transform.parent.gameObject);
            _gameManager.UpdateScore(++_gameManager.score);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(StringConst.RingTag) && enabled)
        {
            ringObjects.Remove(other.transform.parent.gameObject);
            _gameManager.UpdateScore(--_gameManager.score);
        }
    }
}