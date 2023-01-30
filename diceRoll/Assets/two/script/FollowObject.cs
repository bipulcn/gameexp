using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform tar;
    // Start is called before the first fra
    float smoothTime = 0.10f;
    private Vector3 velocity = Vector3.zero;
    Vector3 ups = new Vector3(0, 2.5f, 0);
    public float distance = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 targetPos = tar.position - tar.forward * distance + ups;
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime*Time.deltaTime);
        transform.LookAt(tar);
    }
}
