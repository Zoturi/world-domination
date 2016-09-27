using UnityEngine;
using System.Collections;

public class Sword : Weapon {

    ItemType myItemType;

    void Start ()
    {
        //set base values for Sword
        damage = 20;
        speed = 10;

        amount = 1;

        myItemType = ItemType.Melee;
	}
	

}
