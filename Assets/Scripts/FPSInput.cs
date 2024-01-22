using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class FPSInput : MonoBehaviour
{
    private CharacterController _charController;

    public float speed = 15.0f;
    public float gravity = -9.8f;
    void Start()
    {
        _charController= GetComponent<CharacterController>();
    }

    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;

        Vector3 movment = new Vector3(deltaX , 0, deltaZ );

        movment=Vector3.ClampMagnitude(movment, speed);
        movment.y = gravity;
        movment *= Time.deltaTime;
        movment = transform.TransformDirection(movment);
        _charController.Move(movment);
    }
}
