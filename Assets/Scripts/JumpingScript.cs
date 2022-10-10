using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingScript : MonoBehaviour
{
    public Rigidbody reggiebody;
    public float jumpForce;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && Time.timeScale >=1f)
        {
            reggiebody.AddForce(Vector3.up * jumpForce);
            //reggiebody.AddForce(new Vector(1 1 0).normalize * jumpForce);
        }
    }
}



