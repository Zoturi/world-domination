using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterPanel : ManaPanel {

    public Text charNameText;
    public Text charLvlText;
    public Text charHpText;
    public Text charMpText;
    public Text charAttText;
    public Text charDefText;
    

    private static bool characterPanelOpen;
    
    //property for opening and closing the panel
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
                gameObject.SetActive(true);
                ShowStats(); // get and show the stats for the selected character
            }

            if (characterPanelOpen == false)
            {
                Debug.Log("Character panel closed");
                gameObject.SetActive(false);
            }
        }
    }

    public void ShowStats()
    {
        Debug.Log("Showing stats for selected character");
        //check which player is in use and get that players stats
        if (GameManager.instance.characterManager.SelectedChar.name == "Boy")
        {
            charNameText.text = "Name: " + GameManager.instance.character.NameBoy.ToString();
            charLvlText.text = "Level: " + GameManager.instance.character.LvlBoy.ToString();
            charHpText.text = "Health: " + GameManager.instance.character.HpBoy.ToString();
            charMpText.text = "Mana: " + GameManager.instance.character.MpBoy.ToString();
            charAttText.text = "Attack: " + GameManager.instance.character.AttBoy.ToString();
            charDefText.text = "Defence: " + GameManager.instance.character.DefBoy.ToString();
        }

        if (GameManager.instance.characterManager.SelectedChar.name == "Dog")
        {
            charNameText.text = "Name: " + GameManager.instance.character.NameDog.ToString();
            charLvlText.text = "Level: " + GameManager.instance.character.LvlDog.ToString();
            charHpText.text = "Health: " + GameManager.instance.character.HpDog.ToString();
            charMpText.text = "Mana: " + GameManager.instance.character.MpDog.ToString();
            charAttText.text = "Attack: " + GameManager.instance.character.AttDog.ToString();
            charDefText.text = "Defence: " + GameManager.instance.character.DefDog.ToString(); ;
        }
        
    }


}
