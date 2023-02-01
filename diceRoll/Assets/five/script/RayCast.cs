using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public GameObject obj;
    // Rigidbody rb;
    // Vector3 rotationRight = new Vector3(0, 30, 0);
    // Vector3 rotationLeft = new Vector3(0, -30, 0);
    // Start is called before the first frame update
    void Start()
    {
        // rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 10.9f, Color.red);
        Debug.DrawRay(transform.position, transform.up * 10.9f, Color.green);
        Debug.DrawRay(transform.position, transform.right * 10.9f, Color.blue);
        Debug.DrawRay(transform.position, new Vector3(1, 1, 1) * 5f, Color.white);
        if(Input.GetMouseButtonDown(0)) {
            Vector3 ps = transform.position + transform.forward;
            GameObject pre = Instantiate(obj, ps, Quaternion.identity);
            Vector3 fr = (transform.forward+transform.up)*10f;
            Debug.Log(fr);
            pre.GetComponent<Rigidbody>().AddForce(fr, ForceMode.Impulse);
        }

        if(Input.GetKey("w")) {
            transform.position += transform.forward*10.0f*Time.deltaTime;
        }
        if(Input.GetKey("s")) {
            transform.position -= transform.forward*10.0f*Time.deltaTime;
        }
        if(Input.GetKey("d")) {
            transform.rotation *= Quaternion.Euler(0, 20*Time.deltaTime, 0);
        }
        if(Input.GetKey("a")) {
            transform.rotation *= Quaternion.Euler(0, -20*Time.deltaTime, 0);
        }
    }
}
