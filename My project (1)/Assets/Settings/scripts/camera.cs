using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // O objeto que a câmera vai seguir

    void Update()
    {
        if (target != null)
        {
            // Acompanha a posição X e Y do objeto, mas mantém a câmera no Z original
            transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
        }
    }
}
