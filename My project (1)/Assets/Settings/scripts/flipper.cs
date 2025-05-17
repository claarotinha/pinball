
using UnityEngine;

public class FlipperController : MonoBehaviour
{
    public KeyCode activationKey = KeyCode.LeftArrow;
    private HingeJoint2D hinge;

    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
        hinge.useMotor = true;
        hinge.useLimits = true;

        JointAngleLimits2D limits = new JointAngleLimits2D();
        limits.min = -45f;
        limits.max = 45f;
        hinge.limits = limits;
    }

    void Update()
    {
        JointMotor2D motor = hinge.motor;

        if (Input.GetKey(activationKey))
            motor.motorSpeed = -1000f;
        else
            motor.motorSpeed = 1000f;

        motor.maxMotorTorque = 10000f;
        hinge.motor = motor;
    }
}
