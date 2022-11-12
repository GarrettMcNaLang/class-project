using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereAni : MonoBehaviour
{
    public Animator animator;
    // Update is called once per frame
    void Update()

    {
        if(Input.GetButton("Jump"))
        {
            animator.SetBool("Animation" , true);
        }
        else
            animator.SetBool("Animation", false);

     
    }
}
