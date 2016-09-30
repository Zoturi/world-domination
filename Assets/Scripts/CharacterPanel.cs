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
    public Text charArmorText;
    

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
        Debug.Log("Showing stats for " + GameManager.instance.characterManager.SelectedChar.name);
        //check which player is in use and get that players stats
        if (GameManager.instance.characterManager.SelectedChar.name == "Boy")
        {
            //get base and armor value
            int baseValue = GameManager.instance.character.DefBoy;
            int armorValue = (int)GameManager.instance.character.ArmorBoy;
            int defence = baseValue + armorValue;

            //text output
            charNameText.text = "Name: " + GameManager.instance.character.NameBoy.ToString();
            charLvlText.text = "Level: " + GameManager.instance.character.LvlBoy.ToString();
            charHpText.text = "Health: " + GameManager.instance.character.HpBoy.ToString();
            charMpText.text = "Mana: " + GameManager.instance.character.MpBoy.ToString();
            charAttText.text = "Attack: " + GameManager.instance.character.AttBoy.ToString();
            charDefText.text = "Defence: " + defence.ToString() + " (Base: " + baseValue.ToString() + ", Armor: " + armorValue.ToString() + ")";
            charArmorText.text = "Armor: " + GameManager.instance.character.ArmorBoy;
        }

        if (GameManager.instance.characterManager.SelectedChar.name == "Dog")
        {
            int baseValue = GameManager.instance.character.DefDog;
            int armorValue = (int)GameManager.instance.character.ArmorDog;
            int defence = baseValue + armorValue;

            charNameText.text = "Name: " + GameManager.instance.character.NameDog.ToString();
            charLvlText.text = "Level: " + GameManager.instance.character.LvlDog.ToString();
            charHpText.text = "Health: " + GameManager.instance.character.HpDog.ToString();
            charMpText.text = "Mana: " + GameManager.instance.character.MpDog.ToString();
            charAttText.text = "Attack: " + GameManager.instance.character.AttDog.ToString();
            charDefText.text = "Defence: " + defence.ToString() + " (Base: " + baseValue.ToString() + ", Armor: " + armorValue.ToString() + ")";
            charArmorText.text = "Armor: " + GameManager.instance.character.ArmorDog;
        }
        
    }


}
