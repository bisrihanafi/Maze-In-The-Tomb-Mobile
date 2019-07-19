using UnityEngine;
using System.Collections;

public class CameraAngle : MonoBehaviour
{

    public float rotationSpeed;
    public AngleCamera moveJoystick;
    Vector3 rotation;
    private void Start()
    {
        rotation = transform.eulerAngles;
    }
    void Update()
    {
        rotation.x -= moveJoystick.InputDirection.z * rotationSpeed ;
        //rotation.y += moveJoystick.InputDirection.x * rotationSpeed ;
        transform.eulerAngles = rotation;
    }
}