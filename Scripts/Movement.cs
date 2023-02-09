using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    float xRot, yRot;
    public float speed;
    public Transform cam;
    void Start(){
        rb = GetComponent<Rigidbody>();
    }
    void Update(){
        Vector3 moveDir = transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");
        rb.AddForce(moveDir * speed, ForceMode.Acceleration);

        xRot -= Input.GetAxis("Mouse Y");
        yRot += Input.GetAxis("Mouse X");

        transform.rotation = Quaternion.Euler(0, yRot, 0);
        cam.localRotation = Quaternion.Euler(xRot, 0, 0);
    }
}
