using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayDice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        // Bit shift the index of the layer (8) to get a bit mask
        int layerMask = 1 << 8;

        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
        layerMask = ~layerMask;
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            // Debug.Log("Did Hit");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
        }

        if(Input.GetMouseButtonDown(0))
        {
            // Debug.Log("Clicked");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hts;
            if(Physics.Raycast(ray, out hts))
            {
                Debug.Log("Working hit "+hts.collider.gameObject.name);
                Debug.DrawRay(Camera.main.transform.position, hts.transform.position, Color.yellow);
            }
        }
        Debug.DrawRay(new Vector3(0, 0, 0), new Vector3(0, 10, 0), Color.yellow);
    }
}
