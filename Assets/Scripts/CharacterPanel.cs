using UnityEngine;
using System.Collections;

public class CharacterPanel : ManaPanel {

    public string charBoyName;
    public string charDogName;

    public int charBoyDef;
    public int charDogDef;

    private bool characterPanelOpen;

    void Start () {
        

        Armor myArmor = new Armor();
        Character myChar = new Character(); //create reference

        //get names for dog and boy
        charBoyName = myChar.NameBoy;
        charDogName = myChar.NameDog;

        charBoyDef = myChar.DefBoy;
        Debug.Log("Current defence is " + charBoyDef);
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
            }

            if (characterPanelOpen == false)
            {
                Debug.Log("Character panel closed");
            }
        }
    }
}
