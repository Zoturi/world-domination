using UnityEngine;
using System.Collections;

public class CharacterManager {
    
    private GameObject selectedChar;
    private GameObject followingChar;
    private GameObject boyChar;
    private GameObject dogChar;
    private GameObject[] enemies;

    
    public GameObject SelectedChar { get { return selectedChar; } set { selectedChar = value; } }
    
	public void InitialiseChar () {
        //find player characters from hierarchy
        boyChar = GameObject.FindGameObjectWithTag("PlayerBoy");
        dogChar = GameObject.FindGameObjectWithTag("PlayerDog");
        
        //set default initial player character to boy
        selectedChar = boyChar;
        followingChar = dogChar;

        GameManager.instance.visualCharacterScript.CurrentPlayer = selectedChar;
        GameManager.instance.visualCharacterScript.CurrentFollower = followingChar;

        Debug.Log("Starting game as " + selectedChar);
	}
    
    
    //character change
    public void ChangeChar()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (selectedChar == boyChar)
            {
                selectedChar = dogChar;
                followingChar = boyChar;
                Debug.Log("Changed char to " + selectedChar);
                GameManager.instance.visualCharacterScript.CurrentPlayer = selectedChar;
                GameManager.instance.visualCharacterScript.CurrentFollower = followingChar;

            }
            else if (selectedChar == dogChar)
            {
                selectedChar = boyChar;
                followingChar = dogChar;
                Debug.Log("Changed char to " + selectedChar);
                GameManager.instance.visualCharacterScript.CurrentPlayer = selectedChar;
                GameManager.instance.visualCharacterScript.CurrentFollower = followingChar;
            }

        }
    }

    
}
