using UnityEngine;
using System.Collections;

public class Bow : Weapon {

    ItemType myItemType;

    void Start()
    {
        //set base values for Bow
        damage = 10;
        speed = 15;

        amount = 1;

        myItemType = ItemType.Ranged;
    }
}
