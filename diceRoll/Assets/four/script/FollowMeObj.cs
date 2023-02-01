using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMeObj : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(obj.transform.position, transform.position, Time.deltaTime*0.001f);        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
