using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager {

    public bool pauseMenuOpen;

    public void OpenPanels()
    {
        if (pauseMenuOpen)
        {
            pauseMenuOpen = false;
            if (GameManager.instance.menuButton.activeInHierarchy)
            {
                GameManager.instance.menuButton.SetActive(false);
                Time.timeScale = 1;

            }else if (!GameManager.instance.menuButton.activeInHierarchy)
            {
                GameManager.instance.menuButton.SetActive(true);
                Time.timeScale = 0;
            }


        }

        //open or close inventory panel
        if (Input.GetKeyDown(KeyCode.I))
        {
            
            if (GameManager.instance.inventoryPanelScript.InventoryPanelOpen == false)
            {
                GameManager.instance.inventoryPanelScript.InventoryPanelOpen = true;

            }
            else if (GameManager.instance.inventoryPanelScript.InventoryPanelOpen == true)
            {
                GameManager.instance.inventoryPanelScript.InventoryPanelOpen = false;
            }
        }

        //open or close character panel
        if (Input.GetKeyDown(KeyCode.C))
        {
            
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
