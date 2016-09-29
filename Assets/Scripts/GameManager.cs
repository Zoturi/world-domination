using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    //singleton type setup for GameManager
    public static GameManager instance = null;

    //item gameobjects listed here
    public GameObject goBow;
    public GameObject goSword;

    public int amountOfItemsInInventory;
    
    public InventoryPanel inventoryPanelScript;
    public CharacterPanel characterPanelScript;
    public VisualCharacter visualCharacterScript;
    public GameObject menuButton;

    //create instances
    public CharacterManager characterManager = new CharacterManager();
    public UIManager uiManager = new UIManager();
    public Inventory inventory = new Inventory();
    public Character character = new Character();
    public Armor armor = new Armor();

    private GameObject[] itemsFromInventory;

    void Awake()
    {
        //Check if instance already exists, if so, destroy
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        
        //initialise characters
        characterManager.InitialiseChar();
        
        //add items that go in the inventory here
        inventory.ItemsInInventory[0] = goBow;
        inventory.ItemsInInventory[1] = goSword;

        //get the amount of items in the inventory, to use in InventoryPanel
        amountOfItemsInInventory = inventory.GetAmountOfItemsInInventory();

    }

    void Update()
    {
        characterManager.ChangeChar();
        uiManager.OpenPanels();
    }

    public void PauseControl()
    {

        uiManager.pauseMenuOpen = true;
    }
    
}
