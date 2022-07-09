using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public enum PusherType
{
    PusherOne = 0,
    PusherTwo = 1,
    PusherThree = 2,
    PusherFour = 3,
    PusherFive = 4,
    PusherSix = 5,
}

public class PusherController : MonoBehaviour
{
    public GameObject forceSource;
    public float force = 100;
    public float explosionRadius = 5;

    private PlayerInput _playerInput;
    public PusherType pusherType;
    private List<Rigidbody> _listRingRb;

    private void Awake()
    {
        _playerInput = new PlayerInput();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    private void Start()
    {
        _listRingRb = GamePrefabs.Instance.ringRigidbodyList;
        switch (pusherType)
        {
            case PusherType.PusherOne:
                _playerInput.Gameplay.Controller1.performed += Pushing;
                break;
            case PusherType.PusherTwo:
                _playerInput.Gameplay.Controller2.performed += Pushing;
                break;
        }
    }

    private void OnDestroy()
    {
        switch (pusherType)
        {
            case PusherType.PusherOne:
                _playerInput.Gameplay.Controller1.performed -= Pushing;
                break;
            case PusherType.PusherTwo:
                _playerInput.Gameplay.Controller2.performed -= Pushing;
                break;
        }
    }

    private void Pushing(InputAction.CallbackContext ctx)
    {
        print(ctx);
        AddForceFrom(force);
    }


    private void AddForceFrom(float addedForce)
    {
        var forceSourcePosition = forceSource.transform.position;
        foreach (Rigidbody o in _listRingRb)
        {
            o.AddExplosionForce(addedForce, forceSourcePosition, explosionRadius);
        }
    }
}