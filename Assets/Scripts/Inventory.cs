using UnityEngine;
using System.Collections;

public class Inventory {

    //contains list of items
    public GameObject[] itemsInInventory = new GameObject[2];
    public int amountOfItemsInInventory;
    
    public GameObject[] ItemsInInventory
    {
        get
        {
            return itemsInInventory;
        }

        set
        {
            itemsInInventory = value;
        }
    }

    public int GetAmountOfItemsInInventory()
     {
         for (int i = 0; i < itemsInInventory.Length; i++)
         {
            if (itemsInInventory[i] != null)
            {
                amountOfItemsInInventory++;
            }
            
         }

        return amountOfItemsInInventory;
     }

}
