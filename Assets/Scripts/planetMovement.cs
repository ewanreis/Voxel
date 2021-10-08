using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetMovement : MonoBehaviour
{
    private Vector3 moveDelta;
    Rigidbody planetRigid;
    public float thrust = 20f;

    // Start is called before the first frame update
    void Start()
    {
        planetRigid = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"), y = 0;
        if (x != 0)
            y = 0;
        else if (x == 0)
            y = Input.GetAxisRaw("Vertical");
        moveDelta = new Vector3(x, y, 0);
        //transform.Translate(0, 0, moveDelta.y * Time.deltaTime); // Movement
        //transform.Translate(moveDelta.x * Time.deltaTime, 0, 0); // Movement

        planetRigid.AddForce(0, 0, moveDelta.y * Time.deltaTime, ForceMode.Impulse);
        planetRigid.AddForce(moveDelta.x * Time.deltaTime, 0, 0, ForceMode.Impulse);
    }
}
