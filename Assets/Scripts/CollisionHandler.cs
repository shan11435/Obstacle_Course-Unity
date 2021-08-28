using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
   int hits = 3;
    void OnCollisionEnter(Collision other) 
    {
        //other.gameobject,tag will be the object being collided with 
        switch (other.gameObject.tag)
        {
            //if the object's tag name that's being collided is named start
            case "Start":
                Debug.Log("GOOD LUCK!!!!");
                Debug.Log("You have 3 life points");
                break;
            //if the object's tag name that's being collided is named finish
            case "Finish":
                Debug.Log("Congratulations, you beat the course");
                break;
            //every other object that doesn't have either tags listed in the switch case
            default:
                if(other.gameObject.tag != "hit")
                {
                    hits--;
                    Debug.Log("You have " + hits + " life points");
                }
                if(hits == 0)
                {
                    Debug.Log("You lost the game");
                }
                break;
                
        }
    }
}
