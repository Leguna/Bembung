using UnityEngine;

public class PusherController : MonoBehaviour
{
    private static readonly int Push = Animator.StringToHash("Push");

    public Rigidbody playerRb;
    public GameObject forceSource;
    public float force = 100;
    public KeyCode pusherPressKeyCode;

    private void Update()
    {
        if (Input.GetKeyDown(pusherPressKeyCode))
        {
            if (playerRb.Equals(null)) return;
            
            var forceSourcePosition = forceSource.transform.position;
            Vector3 dir = forceSourcePosition - transform.position;
            dir = dir.normalized;
            
            playerRb.AddForceAtPosition(dir * force,forceSourcePosition);
        }
    }
}