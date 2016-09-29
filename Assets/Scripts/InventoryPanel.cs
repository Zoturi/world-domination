using UnityEngine;
using System.Collections;

public class InventoryPanel : ManaPanel {

    //public static InventoryPanel instance = null;
    private GameObject[] itemsFromInventory;

    private bool inventoryPanelOpen;

    private int amountOfItemsInInventory;

    private GameObject[] items = new GameObject[10];

    //public int AmountOfItems { get; set; }

    //private GameManager gameManagerScript;
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

                    //InventoryPanel.instance.SetInvPanelItems(itemsFromInventory[0], 0);
                    //InventoryPanel.instance.SetInvPanelItems(itemsFromInventory[1], 1);

                    //InventoryPanel.instance.InstantiateInvPanelItems();


                }

                Debug.Log("Inventory panel open");
                InstantiateInvPanelItems();
            }

            if (inventoryPanelOpen == false)
            {
                Debug.Log("Inventory panel closed");
            }


        }
    }

    void OnEnable()
    {
        //find gmScript to get the amount of items in inv value..yeah, not a good way
        // gameManagerScript = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        //amountOfItemsInInventory = gameManagerScript.amountOfItemsInInventory;
        RefreshPanel();
    }

    void Awake()
    {
        //inventoryPanelOpen = true;
        //Check if instance already exists
        /*if (instance == null)
        {
            instance = this;
            
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }*/

        

    }

    public void SetInvPanelItems(GameObject item, int index)
    {
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
        amountOfItemsInInventory = GameManager.instance.amountOfItemsInInventory;
        
        for (int i = 0; i < amountOfItemsInInventory; i++)
        {
            GameObject tempItem = items[i].gameObject;
            
            //Debug.Log(!transform.FindChild(items[i].gameObject.name + "(Clone)"));

            //look for child object of InventoryPanel
            //check if there exists prefabs, that have not yet been added there
            if (!transform.Find(items[i].gameObject.name + "(Clone)"))
            {
                GameObject go = Instantiate(items[i]);
                go.transform.parent = transform;
                go.transform.position = new Vector2(transform.position.x/1.7f, go.transform.position.y);
            }
        }
    }

   
	

}
