using UnityEngine;
using System.Collections;

public class Armor : Item {

    public enum armorType { none = 0, leather = 10, wood = 30, steel = 50, mithril = 70, elemental = 100 };
    public ItemType itemType = Item.ItemType.Armor;

    private armorType curArmor;

    public armorType CurArmor
    {

        get
        {
            if (GameManager.instance.characterManager.SelectedChar.name == "Boy")
            {
                curArmor = GameManager.instance.character.ArmorBoy;
            }
                return curArmor;
        }
        set
        {
            curArmor = value;
            
            //set armor to currently selected character
            if (GameManager.instance.characterManager.SelectedChar.name == "Boy")
            {
                GameManager.instance.character.DefBoy += (int)curArmor;
                Debug.Log("Added " + curArmor + " armor for boy");
            }

            if (GameManager.instance.characterManager.SelectedChar.name == "Dog")
            {
                GameManager.instance.character.DefDog += (int)curArmor;
                Debug.Log("Added " + curArmor + " armor for dog");
            }


        }
    }
           
    
}

