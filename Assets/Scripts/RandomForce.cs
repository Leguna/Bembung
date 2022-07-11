using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomForce : MonoBehaviour
{
    public List<Transform> listPos;
    public Vector2 randomForce;
    public float explosionRadius = 5;

    public Vector2 randomRepeatRate;
    private float _timer = 3;
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        _timer -= Time.deltaTime;
        if (_timer <= 0)
        {
            _timer = GetRandomTime();
            StartRandomForce();
            _audioSource.Play();
        }
    }

    private void StartRandomForce()
    {
        var rigidbodyList = GamePrefabs.Instance.ringRigidbodyList;
        foreach (Rigidbody o in rigidbodyList)
            o.AddExplosionForce(GetRandomForce(), GetRandomPos(), explosionRadius);
    }
    private Vector3 GetRandomPos() => listPos[Random.Range(0, listPos.Count)].transform.position;
    private float GetRandomTime() => Random.Range(randomRepeatRate.x, randomRepeatRate.y);
    private float GetRandomForce() => Random.Range(randomForce.x, randomForce.y);
}