using UnityEngine;
using System.Collections;

public class Armor : Item {

    armorType curArmor;

    void Start()
    {
        curArmor = armorType.elemental;

        Character myChar = new Character();
        myChar.DefBoy = myChar.DefBoy + (int)curArmor;
    }
    
        
    
}

enum armorType { none = 0, leather = 10, wood = 30, steel = 50, mithril = 70, elemental = 100 };