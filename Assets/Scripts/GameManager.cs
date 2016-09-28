using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public static bool isAlive;
    public static int health;
    //variables
    
   
    public int amountOfItemsInInventory;

    //private InventoryPanel inventoryPanelScript;
    /*
    private int mana;
    private int level;
    private int attack;
    private int defence;
    
    */
    //properties
    /*public bool IsAlive { get; set; }
    public int Health { get; set; }
    public int Mana { get; set; }
    public int Level { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    */
    public GameObject goBow;
    public GameObject goSword;

    public GameObject goInventoryPanel;
    public GameObject goCharacterPanel;

    public InventoryPanel inventoryPanelScript;
    public CharacterPanel characterPanelScript;

    public CharacterManager characterManager = new CharacterManager();
    public UIManager uiManager = new UIManager();
    public Inventory inventory = new Inventory();

    public Character character = new Character();
    //public static Character character = null;

    private GameObject[] itemsFromInventory;
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        /*inventoryPanelScript = goInventoryPanel.GetComponent<InventoryPanel>();

        InventoryPanel test = GameObject.Find("InventoryPanel").GetComponent<InventoryPanel>();

        uiManager.inventoryPanel = test;

        Debug.Log("InviGM: " + test);
        */

        characterManager.InitialiseChar();

        

        //add items that go in the inventory here
        inventory.ItemsInInventory[0] = goBow;
        inventory.ItemsInInventory[1] = goSword;

        //get the amount of items in the inventory, to use in InventoryPanel
        amountOfItemsInInventory = inventory.GetAmountOfItemsInInventory();

        //inventory.GetInventory();

        
    }

    void Start()
    {
        isAlive = true;
        health = 30;
        
    }

    void Update()
    {
        characterManager.ChangeChar();
        uiManager.OpenPanels();


        if (uiManager.inventoryPanel.InventoryPanelOpen == true)
        {
            if (!goInventoryPanel.activeInHierarchy)
            { 
                InventoryPanelOpened();
            }
        }

        if (uiManager.inventoryPanel.InventoryPanelOpen == false)
        {
            if (goInventoryPanel.activeInHierarchy)
            {
                InventoryPanelClosed();
            }
        }

        if (uiManager.characterPanel.CharacterPanelOpen == true)
        {
            if (!goCharacterPanel.activeInHierarchy)
            {
                CharacterPanelOpened();
            }
        }

        if (uiManager.characterPanel.CharacterPanelOpen == false)
        {
            if (goCharacterPanel.activeInHierarchy)
            {
                CharacterPanelClosed();
            }
        }

    }

    void InventoryPanelOpened()
    {
       if (goInventoryPanel == null)
        {
            //GameObject instance = Instantiate(Resources.Load("InventoryPanel", typeof(GameObject))) as GameObject;

            //goInventoryPanel = instance;
            //inventoryPanelScript = goInventoryPanel.GetComponent<InventoryPanel>();
           
        }
        
        if (goInventoryPanel != null)
        {
            if (goInventoryPanel.activeSelf == false)
            {
                goInventoryPanel.SetActive(true);

                //get the items in inventory
                itemsFromInventory = inventory.ItemsInInventory;

                //set items from inventory to inventory panel (I got stumped by this, so I had to come up with something)
                //should check for length and expand from that, but here we set only bow and sword, as we now there is no more
                inventoryPanelScript.SetInvPanelItems(itemsFromInventory[0], 0);
                inventoryPanelScript.SetInvPanelItems(itemsFromInventory[0], 1);

                //InventoryPanel.instance.SetInvPanelItems(itemsFromInventory[0], 0);
                //InventoryPanel.instance.SetInvPanelItems(itemsFromInventory[1], 1);

                //InventoryPanel.instance.InstantiateInvPanelItems();


            }

            //goInventoryPanel.amoun inventory.ItemsInInventory();

            //inventory.GetInventory(); 

        }
    }

    

    void InventoryPanelClosed()
    {
        if (goInventoryPanel != null)
        {
            goInventoryPanel.SetActive(false);
            
        }
    }

    void CharacterPanelOpened()
    {

        if (goCharacterPanel == null)
        {
            GameObject instance = Instantiate(Resources.Load("CharacterPanel", typeof(GameObject))) as GameObject;

            goCharacterPanel = instance;
        }

        if (goCharacterPanel != null)
        {
            goCharacterPanel.SetActive(true);
        }
    }

    void CharacterPanelClosed()
    {
        if (goCharacterPanel != null)
        {
            goCharacterPanel.SetActive(false);
        }
    }
}
