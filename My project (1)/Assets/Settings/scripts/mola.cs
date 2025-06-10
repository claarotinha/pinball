using UnityEngine;

public class lancador : MonoBehaviour
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
            Debug.LogError("mola: faltando referência de mola ou anchor.");
            enabled = false;
            return;
        }

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

            Vector2 alvo = (Vector2)anchor.position - Vector2.up * pullDistance;
            transform.position = Vector2.Lerp(transform.position, alvo, Time.deltaTime * pullSpeed);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow) && isPulling)
        {
            isPulling = false;
           
        }
    }
}