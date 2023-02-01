using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour
{
    public Camera camer;
    int sw, sh;
    float px, pz;
    Vector3 tarp = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        // camer = GetComponent<Camera>();
       sw = (Screen.width-20)/10;
       sh = (Screen.height-20)/10;
       Debug.Log(sw+", "+sh);
       px =  Random.Range(-sw/2, sw/2);
       pz =  Random.Range(-sh/2, sh/2);
    //    Vector3 pnt = camer.ScreenToWorldPoint(px, 0, pz);
    //    Debug.Log(pnt);
       transform.position = new Vector3(px, 0.5f, pz);
        // Vector3 bottomLeft = new Vector3(0, 0, 0);
        // Vector3 topRight = new Vector3(Screen.width, Screen.height, 0);
        // bottomLeft = camer.ScreenToWorldPoint(bottomLeft);
        // topRight = camer.ScreenToWorldPoint(topRight);
        // Vector3 size = topRight - bottomLeft;
        // Debug.Log("Screen size in units: " + size);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            px =  Random.Range(-sw/2, sw/2);
            pz =  Random.Range(-sh/2, sh/2);
            tarp = new Vector3(px, 0.5f, pz);
        }
        transform.position = Vector3.Lerp(transform.position, tarp, 1f*Time.deltaTime);
    }
}
