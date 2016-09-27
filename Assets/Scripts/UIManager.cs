using UnityEngine;
using System.Collections;

public class UIManager {

    //Panels
    public InventoryPanel inventoryPanel = new InventoryPanel();
    public CharacterPanel characterPanel = new CharacterPanel();
    public ManaPanel manaPanel;
    
    

    void Start()
    {
        //initialise panels
        manaPanel.InitialisePanel();
        inventoryPanel.InitialisePanel();
        characterPanel.InitialisePanel();
        
    }

    public void OpenPanels()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            //open or close inventory panel
            if (inventoryPanel.InventoryPanelOpen == false)
            {
                inventoryPanel.InventoryPanelOpen = true;

            }
            else if (inventoryPanel.InventoryPanelOpen == true)
            {
                inventoryPanel.InventoryPanelOpen = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            //open or close inventory panel
            if (characterPanel.CharacterPanelOpen == false)
            {
                characterPanel.CharacterPanelOpen = true;

            }
            else if (characterPanel.CharacterPanelOpen == true)
            {
                characterPanel.CharacterPanelOpen = false;
            }
        }

    }
	
}
