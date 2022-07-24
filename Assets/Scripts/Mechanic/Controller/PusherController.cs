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
    private GameManager _gameManager;
    private AudioSource _audioSource;

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
        _gameManager = GameManager.Instance;
        TryGetComponent(out _audioSource);

        _playerInput.Gameplay.TouchX.performed += OnTouch;
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
        var pos = ctx.ReadValue<float>();
        if (pos < Screen.width / 2f && pusherType == PusherType.PusherOne)
        {
            Pushing(ctx);
        }
        else if (pos > Screen.width / 2f && pusherType == PusherType.PusherTwo)
        {
            Pushing(ctx);
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
        if (_gameManager.isGameplayStarted && !_gameManager.isGamePaused)
        {
            AddForceFrom(force);
            _audioSource.Play();
        }
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