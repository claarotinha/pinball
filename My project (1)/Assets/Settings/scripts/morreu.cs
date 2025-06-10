using UnityEngine;
using UnityEngine.SceneManagement;

public class BallReset : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bola"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
