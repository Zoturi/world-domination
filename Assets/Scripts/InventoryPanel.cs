using UnityEngine;
using System.Collections;

public class InventoryPanel : ManaPanel {

    //public static InventoryPanel instance = null;
    public GameObject slot1;
    public GameObject slot2;

    private GameObject[] slots = new GameObject[2];
    private GameObject[] itemsFromInventory;
    private GameObject[] items = new GameObject[10];
    private GameObject go; //for prefab instantiation
    private bool inventoryPanelOpen;
    private int amountOfItemsInInventory;

    //property for opening and closing the panel
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
                if (gameObject.activeSelf == false)
                {
                    gameObject.SetActive(true);

                    //get the items in inventory
                    itemsFromInventory = GameManager.instance.inventory.itemsInInventory;

                    //set items from inventory to inventory panel (I got stumped by this, so I had to come up with something)
                    //should check for length and expand from that, but here we set only bow and sword, as we now there is no more
                    SetInvPanelItems(itemsFromInventory[0], 0);
                    SetInvPanelItems(itemsFromInventory[1], 1);

                }

                Debug.Log("Inventory panel open");
                InstantiateInvPanelItems();
            }

            if (inventoryPanelOpen == false)
            {
                Debug.Log("Inventory panel closed");
                gameObject.SetActive(false);
            }
            
        }
    }

    void Awake()
    {
        //set  inventory slots to array for distribution in the item listing (no need for more in this test)
        slots[0] = slot1;
        slots[1] = slot2;
    }
    void OnEnable()
    {
        RefreshPanel();
    }
    
    public void SetInvPanelItems(GameObject item, int index)
    {
        //set the items that are to be included in the inventorypanel
        if (items[index] == null)
        { 
            items[index] = item;
            Debug.Log("Setting" + items[index]);
        }else if (items[index] != null)
        {
            Debug.Log("Already set " + items[index]);
        }

    }

    public void InstantiateInvPanelItems()
    {
        //get the amount of items added to inventory (in GamemManager)
        amountOfItemsInInventory = GameManager.instance.amountOfItemsInInventory;
        
        for (int i = 0; i < amountOfItemsInInventory; i++)
        {
     
            //look for child object of InventoryPanel
            //check if there exists prefabs, that have not yet been added there
            if (!GameObject.Find(items[i].gameObject.name + "(Clone)"))
            {
                go = Instantiate(items[i]) as GameObject;
                go.transform.parent = slots[i].transform;
                go.transform.position = new Vector2(slots[i].transform.position.x, slots[i].transform.position.y);
                go.transform.localScale = new Vector2(1, 1);
            }
        }

    }
    
}
