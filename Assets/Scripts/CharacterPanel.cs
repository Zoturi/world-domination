using UnityEngine;
using System.Collections;

public class CharacterPanel : ManaPanel {

    public string charName;
    public int charHealth;
    public int charDef;
    public int charAtt;

    private static bool characterPanelOpen;
    

    public CharacterPanel() {
        
        /*
        Armor myArmor = new Armor();
        Character myChar = new Character(); //create reference

        //get names for dog and boy
        charBoyName = myChar.NameBoy;
        charDogName = myChar.NameDog;

        charBoyDef = myChar.DefBoy;
        Debug.Log("Current defence is " + charBoyDef);
        Debug.Log("Boys name: " + charBoyName);
        */
	}

    public bool CharacterPanelOpen
    {
        get
        {
            return characterPanelOpen;
        }

        set
        {
            characterPanelOpen = value;

            if (characterPanelOpen == true)
            {
                Debug.Log("Character panel open");
                

                ShowStats();
            }

            if (characterPanelOpen == false)
            {
                
                Debug.Log("Character panel closed");
            }
        }
    }

    void ShowStats()
    {
        
        Debug.Log("Showing stats for selected character");
        //check which player is in use and get that players stats
        if (GameManager.instance.characterManager.SelectedChar.name == "Boy")// kesken, onko pojan nimi tuo vai esim + (clone)?
        {
            charHealth = GameManager.instance.character.HpBoy;
            charDef = GameManager.instance.character.DefBoy;
        }

        if (GameManager.instance.characterManager.SelectedChar.name == "Dog")
        {
            charHealth = GameManager.instance.character.HpDog;
            charDef = GameManager.instance.character.DefDog;
        }


    }

    void OnGUI() //not used anymore
    {
       /*
        if (characterPanelOpen)
        {
            float cameraPixelHeight = Camera.main.pixelHeight;
            float cameraPixelWidth = Camera.main.pixelWidth;
            GUI.Label(new Rect(cameraPixelWidth / 11f, cameraPixelHeight / 5.2f, 150, 30), "Name: " + charName);
            GUI.Label(new Rect(cameraPixelWidth / 11f, cameraPixelHeight / 5.2f, 150, 30), "Name: " + charHealth);
            GUI.Label(new Rect(cameraPixelWidth / 11f, cameraPixelHeight / 5.2f, 150, 30), "Name: " + charDef);
            GUI.Label(new Rect(cameraPixelWidth / 11f, cameraPixelHeight / 5.2f, 150, 30), "Name: " + charAtt);

        }
        */
    }
}
