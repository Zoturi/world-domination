using UnityEngine;
using System.Collections;

public class Armor : Item {

    enum armorType { none = 0, leather = 10, wood = 30, steel = 50, mithril = 70, elemental = 100 };

    armorType curArmor;
    
    public void addArmor()
    {
        curArmor = armorType.elemental;

        GameManager.instance.character.DefBoy += (int)curArmor;
        
    }
           
    
}

