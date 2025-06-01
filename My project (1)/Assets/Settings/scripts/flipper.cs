
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public KeyCode key;
    private HingeJoint2D hinge;

    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
    }

    void Update()
    {
        JointMotor2D motor = hinge.motor;

        if (Input.GetKey(key))
        {
            motor.motorSpeed = -1000f; // Use -1000 ou 1000 dependendo do lado
        }
        else
        {
            motor.motorSpeed = 1000f;
        }

        hinge.motor = motor;
    }
}
