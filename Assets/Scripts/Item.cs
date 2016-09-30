using UnityEngine;
using System.Collections;

public abstract class Item {

    public enum ItemType { Armor, Melee, Ranged, Potion, Magic };

    public int amount { get; set; }
    
}
