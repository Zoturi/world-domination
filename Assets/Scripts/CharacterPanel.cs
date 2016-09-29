using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterPanel : ManaPanel {

    public Text healthText;
    public Text charDefText;

    public string charName;
    public int charHealth;
    public int charDef;
    public int charAtt;

    private static bool characterPanelOpen;
    
    

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

    

    public void ShowStats()
    {
        
        Debug.Log("Showing stats for selected character");
        //check which player is in use and get that players stats
        if (GameManager.instance.characterManager.SelectedChar.name == "Boy")
        {
            charHealth = GameManager.instance.character.HpBoy;
            charDef = GameManager.instance.character.DefBoy;
            
            healthText.text = "Health: " + charHealth.ToString();
            charDefText.text = "Defence: " + charDef.ToString();
        }

        if (GameManager.instance.characterManager.SelectedChar.name == "Dog")
        {
            charHealth = GameManager.instance.character.HpDog;
            charDef = GameManager.instance.character.DefDog;

            healthText.text = "Health: " + charHealth.ToString();
            charDefText.text = "Defence: " + charDef.ToString();
        }


    }


}
