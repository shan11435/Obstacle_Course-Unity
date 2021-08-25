using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 4;

   
    private void OnCollisionEnter(Collision other) 
    {   
        //if the objects tag doesn't equal Hit
        if(other.gameObject.tag != "Hit")
        {
            hits--;
            Debug.Log("You have  " + hits + " life points");
        }
        if(hits == 0){
            Debug.Log("You lost the game");
        }
        
    }
}
