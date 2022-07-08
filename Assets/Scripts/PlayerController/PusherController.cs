using System;
using UnityEditor;
using UnityEngine;

enum PusherType
{
    pusherOne = 0,
    pusherTwo = 1,
    pusherThree = 2,
    pusherFour = 3,
}

public class PusherController : MonoBehaviour
{
    private static readonly int Push = Animator.StringToHash("Push");

    public Rigidbody playerRb;
    public GameObject forceSource;
    public float force = 100;

    private PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = new PlayerInput();
    }

    private void OnDestroy()
    {
        throw new NotImplementedException();
    }

    private void Update()
    {
        
    }

    private void AddForceFrom(float addedForce, PusherType pusherType)
    {
        var forceSourcePosition = forceSource.transform.position;
        playerRb.AddExplosionForce(addedForce, forceSourcePosition,5);
    }
}