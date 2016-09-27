using UnityEngine;
using System.Collections;

public abstract class Item {

    public int amount { get; set; }
    
}
enum ItemType { Armor, Melee, Ranged, Potion, Magic };