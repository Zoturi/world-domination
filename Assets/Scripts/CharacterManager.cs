using UnityEngine;
using System.Collections;

public class CharacterManager {
    
    private GameObject selectedChar;
    private GameObject boyChar;
    private GameObject dogChar;

    private GameObject[] enemies;

    public GameObject SelectedChar
    {
        get
        {
            return selectedChar;
        }

        set
        {
            selectedChar = value;
        }
    }
    
	public void InitialiseChar () {
        //find player characters from hierarchy
        boyChar = GameObject.FindGameObjectWithTag("PlayerBoy");
        dogChar = GameObject.FindGameObjectWithTag("PlayerDog");
        //set default initial player character to boy
        selectedChar = boyChar; 

        Debug.Log("Starting game as " + selectedChar);
	}
    
    public void ChangeChar()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {

            if (selectedChar == boyChar)
            {
                selectedChar = dogChar;
                Debug.Log("Changed char to Dog");
                Debug.Log(selectedChar);

            }else if (selectedChar == dogChar)
            {
                selectedChar = boyChar;
                Debug.Log("Changed char to Boy");
                Debug.Log(selectedChar);
            }

        }
    }

    
}
