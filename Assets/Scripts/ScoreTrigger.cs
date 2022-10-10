using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{//the static keyword makes it shared between all instances of this script
    static int score = 0;
    public TextMeshProUGUI Scoretext;


    void OnTriggerEnter(Collider other)
    {
        //We check if the other collider has 
        //the tag "beans" on its object
        if (other.gameObject.tag == "beans")
 
        {
            
            score++;
            Scoretext.text = "Score" + score.ToString();
            //is the same as saying
            //score = score + 1;
            //and increases the value of score by 1

            Debug.Log(transform.name + " : " + score);
        }
    }
}