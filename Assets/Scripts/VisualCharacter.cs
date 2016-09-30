using UnityEngine;
using System.Collections;

public class VisualCharacter : MonoBehaviour {

    private static GameObject currentPlayer;
    private static GameObject currentFollower;

    private float moveSpeed = 2.0f;
    public GameObject CurrentPlayer
    {
        get
        {
            return currentPlayer;
        }
        set
        {
            currentPlayer = value;
            Debug.Log("Current player is " + currentPlayer.name);
        }
    }
    public GameObject CurrentFollower
    {
        get
        {
            return currentFollower;
        }
        set
        {
            currentFollower = value;
            Debug.Log("Current follower is " + currentFollower.name);
        }
    }

    void Update()
    {
        Controls();
        FollowOther();
    }

    void Controls()
    {
        //move player according to controls
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        currentPlayer.transform.position += move * moveSpeed * Time.deltaTime;
    }

    void FollowOther()
    {
        //get distance between following and playing char
        float distance = Vector2.Distance(currentPlayer.transform.position, currentFollower.transform.position);
        
        //follower keeps its distance
        if (distance > 2)
        { 
            //follow
            currentFollower.transform.position = Vector2.MoveTowards(currentFollower.transform.position, CurrentPlayer.transform.position, Time.deltaTime * moveSpeed/2f);
            currentFollower.transform.right = currentPlayer.transform.position - currentFollower.transform.position; //rotate the following char to the player char
        }

    }
}
