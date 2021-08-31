using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
                ReloadLevel();
                break;
            //every other object that doesn't have either tags listed in the switch case
            default:
                if(other.gameObject.tag != "Hit")
                {
                    hits--;
                    Debug.Log("You have " + hits + " life points");
                }
                if(hits == 0)
                {
                    ReloadLevel();
                }
                break;
                
        }
    }

    void LoadNextLevel()
    {
        //it's the level the player is currently in
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        //go the next level by adding one to the scene index
        int nextSceneIndex = currentSceneIndex + 1;
        //if the player is in the last scene that was created
        if(nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            //transport player back to scene index 0
            nextSceneIndex = 0;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }

    void ReloadLevel()
    {
        hits = 3;
        Debug.Log("You have " + hits + " life points");
        //goes back to the level the player is currently in
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
