using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Rigidbody2D ball;          // A bola que será lançada
    public float launchForce = 500f;  // A força do lançamento
    public KeyCode launchKey = KeyCode.Space; // A tecla que vai lançar a bola

    private bool isBallInLauncher = false;  // Verifica se a bola está no lançador

    void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se a bola entrou na área do lançador
        if (other.CompareTag("Ball"))
        {
            isBallInLauncher = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // Quando a bola sai da área do lançador
        if (other.CompareTag("Ball"))
        {
            isBallInLauncher = false;
        }
    }

    void Update()
    {
        // Quando apertar a tecla de lançamento, e a bola estiver no lançador
        if (Input.GetKeyDown(launchKey) && isBallInLauncher)
        {
            // Aplica a força para cima na bola
            ball.AddForce(Vector2.up * launchForce);
        }
    }
}
