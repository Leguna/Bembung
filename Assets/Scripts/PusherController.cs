using UnityEditor;
using UnityEngine;

public class PusherController : MonoBehaviour
{
    private static readonly int Push = Animator.StringToHash("Push");

    public Rigidbody playerRb;
    public GameObject forceSource;
    public float force = 100;
    public KeyCode pusherPressKeyCode;

    [Header("Editor Only")] public GameObject source;

    private void Update()
    {
        if (Input.GetKeyDown(pusherPressKeyCode))
        {
            if (playerRb.Equals(null)) return;

            var forceSourcePosition = forceSource.transform.position;
            playerRb.AddExplosionForce(force, forceSourcePosition,5);
        }
    }
}