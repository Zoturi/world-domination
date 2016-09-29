using UnityEngine;
using System.Collections;

public class VisualCharacter : MonoBehaviour {

    private static GameObject currentPlayer;
    private static GameObject currentFollower;
 
    public GameObject CurrentPlayer
    {
        get
        {
            return currentPlayer;
        }
        set
        {
            currentPlayer = value;
            Debug.Log("Current visChar player target is " + currentPlayer.name);
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
            Debug.Log("Current visChar follower target is " + currentFollower.name);
        }
    }
    void Update()
    {

        Controls();

    }

    void Controls()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            currentPlayer.transform.position = new Vector3(currentPlayer.transform.position.x, currentPlayer.transform.position.y + Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            currentPlayer.transform.position = new Vector3(currentPlayer.transform.position.x, currentPlayer.transform.position.y - Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            currentPlayer.transform.position = new Vector3(currentPlayer.transform.position.x - Time.deltaTime, currentPlayer.transform.position.y);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            currentPlayer.transform.position = new Vector3(currentPlayer.transform.position.x + Time.deltaTime, currentPlayer.transform.position.y);
        }
    }

    public void ChangeContorolled()
    {
        //GameManager.instance.characterManager.SelectedChar;
    }
}
