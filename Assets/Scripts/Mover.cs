using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    // Serialize field allows you to change the values in unity while the game is playing
    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    { 
        MovePlayer();
    }

    //this method sends a message to unity console
    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("use the arrow keys or WASD to move the player around");
        Debug.Log("your objective is to run around the obstacle course without hitting anything");
        Debug.Log("hitting anything will result in losing the game");
    }

    //this method makes the object move with the arrow keys or WASD keys
    void MovePlayer()
    {
        //Input.getAxis is getting the information from unity project settings
        // time.deltaTime is the fps a persons computer can output
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }

}
