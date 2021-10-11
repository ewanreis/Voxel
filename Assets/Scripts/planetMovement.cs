using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetMovement : MonoBehaviour
{   private Vector3 moveDelta;
    Rigidbody planetRigid;
    public float thrust = 0.6f;
    void Start()
    {   planetRigid = GetComponent<Rigidbody>();
    }
    void Update()
    {   float x = Input.GetAxisRaw("Horizontal"), y = Input.GetAxisRaw("Vertical");
        moveDelta = new Vector3(x, y, 0);
        planetRigid.AddForce(0, 0, moveDelta.y * Time.deltaTime, ForceMode.Impulse);
        planetRigid.AddForce(moveDelta.x * Time.deltaTime, 0, 0, ForceMode.Impulse);
    }
}
