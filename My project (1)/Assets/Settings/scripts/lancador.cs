using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Rigidbody2D ball;
    public float launchForce = 500f;
    public KeyCode launchKey = KeyCode.Space;

    void Update()
    {
        if (Input.GetKeyDown(launchKey))
        {
            ball.AddForce(Vector2.up * launchForce);
        }
    }
}

