using UnityEngine;
using System.Collections;

public class UIManager {

    //Panels
    //public InventoryPanel inventoryPanel = new InventoryPanel();
    //public CharacterPanel characterPanel = new CharacterPanel();
    
    
    public UIManager()
    {
        //inventoryPanel = ipGo.GetComponent<InventoryPanel>();
        //characterPanel = cp;
        //initialise panels
        Initialize();
        
        
    }

    public void Initialize()
    {
        
        //GameManager.instance.inventoryPanelScript.InitialisePanel();
        //GameManager.instance.characterPanelScript.InitialisePanel();
    }

    public void OpenPanels()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            //open or close inventory panel
            if (GameManager.instance.inventoryPanelScript.InventoryPanelOpen == false)
            {
                GameManager.instance.inventoryPanelScript.InventoryPanelOpen = true;

            }
            else if (GameManager.instance.inventoryPanelScript.InventoryPanelOpen == true)
            {
                GameManager.instance.inventoryPanelScript.InventoryPanelOpen = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            
            //open or close inventory panel
            if (GameManager.instance.characterPanelScript.CharacterPanelOpen == false)
            {
                GameManager.instance.characterPanelScript.CharacterPanelOpen = true;
            }
            else if (GameManager.instance.characterPanelScript.CharacterPanelOpen == true)
            {
                GameManager.instance.characterPanelScript.CharacterPanelOpen = false;
            }
        }

    }
	
}
