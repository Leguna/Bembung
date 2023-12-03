using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;

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
    private GameRunner _gameRunner;
    private AudioSource _audioSource;

    private void Awake()
    {
        _playerInput = new PlayerInput();
        EnhancedTouchSupport.Enable();
    }

    private void OnEnable() => _playerInput.Enable();

    private void OnDisable() => _playerInput.Disable();

    private void Start()
    {
        _listRingRb = GamePrefabs.Instance.ringRigidbodyList;
        _gameRunner = GameRunner.Instance;
        TryGetComponent(out _audioSource);
        _playerInput.Gameplay.TouchTap.performed += OnTouch;

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


    private void OnTouch(InputAction.CallbackContext ctx)
    {
        try
        {
            var posX = _playerInput.Gameplay.TouchPosition.ReadValue<Vector2>().x;
            if (posX < Screen.width / 2f && pusherType == PusherType.PusherOne)
                Pushing(ctx);
            else if (posX > Screen.width / 2f && pusherType == PusherType.PusherTwo)
                Pushing(ctx);
        }
        catch (Exception e)
        {
            Debug.Log(e);
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
        if (!_gameRunner.isGameplayStarted || _gameRunner.isGamePaused) return;
        AddForceFrom(force);
        _audioSource.Play();
    }

    private void AddForceFrom(float addedForce)
    {
        var forceSourcePosition = forceSource.transform.position;
        foreach (Rigidbody o in _listRingRb) o.AddExplosionForce(addedForce, forceSourcePosition, explosionRadius);
    }
}