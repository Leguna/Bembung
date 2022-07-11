using System.Collections.Generic;
using Base;
using UnityEngine;
using UnityEngine.Events;

public class RingGoalTrigger : MonoBehaviour
{
    [HideInInspector] public List<GameObject> ringObjects;
    public UnityEvent onTriggerEnterCallback;
    public UnityEvent onTriggerExitCallback;

    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = GameManager.Instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(StringConstant.RingTag) && enabled)
        {
            ringObjects.Add(other.transform.parent.gameObject);
            onTriggerEnterCallback.Invoke();
            _gameManager.UpdateScore(++_gameManager.score);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(StringConstant.RingTag) && enabled)
        {
            ringObjects.Remove(other.transform.parent.gameObject);
            onTriggerExitCallback.Invoke();
            _gameManager.UpdateScore(--_gameManager.score);
        }
    }
}