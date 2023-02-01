using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMe : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animator;    
    // Animator animator;
    void Start()
    {
        // animator = GetComponent<animator>();           
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w")) {
            Debug.Log("Got a key");
            // animator.SetBool("WalkForward", true);            
            animator.SetBool("WalkForward", true);
        }
        else {
            animator.SetBool("WalkForward", false);
        }
    }
}
