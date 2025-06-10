using UnityEngine;

public class ShooterSpring : MonoBehaviour
{
    public SpringJoint2D mola;
    public Transform anchor;
    public float pullDistance = 2f;
    public float pullSpeed = 10f;

    private bool isPulling = false;

    void Start()
    {
        if (mola == null || anchor == null)
        {
            Debug.LogError("ShooterSpring: faltando referência de mola ou anchor.");
            enabled = false;
            return;
        }

        // Conecta a mola ao ponto fixo
        mola.connectedBody = null;
        mola.autoConfigureConnectedAnchor = false;
        mola.connectedAnchor = anchor.position;
        mola.enabled = true;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            isPulling = true;

            // Move o shooter para baixo
            Vector2 alvo = (Vector2)anchor.position - Vector2.up * pullDistance;
            transform.position = Vector2.Lerp(transform.position, alvo, Time.deltaTime * pullSpeed);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow) && isPulling)
        {
            isPulling = false;
            // Ao soltar, a mola volta à posição inicial naturalmente pela física
        }
    }
}
