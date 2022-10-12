using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroids : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Destroy the other object
            Destroy(collision.gameObject);
        }
    }
}

//Will work with collisions instead of triggers
