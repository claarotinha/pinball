using UnityEngine;
public class Launcher : MonoBehaviour
{
    public Rigidbody2D ball;
    public float launchForce = 500f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ball.AddForce(Vector2.up * launchForce);
        }
    }
}
