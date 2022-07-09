using System.Collections.Generic;
using Base;
using UnityEngine;
using UnityEngine.Events;

public class RingGoalTrigger : MonoBehaviour
{
    [HideInInspector] public List<GameObject> ringObjects;
    public UnityEvent onTriggerEnterCallback;
    public UnityEvent onTriggerExitCallback;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(StringConstant.RingTag))
        {
            ringObjects.Add(other.transform.parent.gameObject);
            onTriggerEnterCallback.Invoke();
            Debug.Log(ringObjects.Count);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(StringConstant.RingTag))
        {
            ringObjects.Remove(other.transform.parent.gameObject);
            onTriggerExitCallback.Invoke();
            Debug.Log(ringObjects.Count);
        }
    }
}