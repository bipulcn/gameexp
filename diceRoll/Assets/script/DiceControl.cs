using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceControl : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0, 0.5f, 0);
        if (Input.GetKey("w"))
        {
            Debug.Log("key was down");
            Vector3 force = new Vector3(0.5f, 0.1f, 0.01f);
            Vector3 rever = new Vector3(0f, 0.1f, -0.1f);
            rb.AddTorque(force, ForceMode.Impulse);
            rb.AddForce(rever, ForceMode.Impulse);
        }
        if(Input.GetKey("f"))
        {
            Vector3 v3 = rb.transform.forward;
            Debug.Log(v3);
        }
    }
}
