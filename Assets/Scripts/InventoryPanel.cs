using UnityEngine;
using System.Collections;

public class InventoryPanel : ManaPanel {

    private bool inventoryPanelOpen;

	void Start () {
        
	}

     
    public bool InventoryPanelOpen
    {
        get
        {
            
            return inventoryPanelOpen;
        }

        set
        {
            inventoryPanelOpen = value;

            if (inventoryPanelOpen == true)
            {
                Debug.Log("Inventory panel open");
            }

            if (inventoryPanelOpen == false)
            {
                Debug.Log("Inventory panel closed");
            }
        }
    }
	

}
