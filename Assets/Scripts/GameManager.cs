using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    //variables
    public GameObject goInventoryPanel;
    public GameObject goCharacterPanel;

    private bool isAlive;
    private int health;
    private int mana;
    private int level;
    private int attack;
    private int defence;
    private GameObject[] inventory;

    

    //properties
    public bool IsAlive { get; set; }
    public int Health { get; set; }
    public int Mana { get; set; }
    public int Level { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public GameObject[] Inventory { get; set; }

    public CharacterManager characterManager = new CharacterManager();
    public UIManager uiManager = new UIManager();

    void Awake()
    {
        characterManager.InitialiseChar();

        
    }

    void Start()
    {
        IsAlive = true;
        health = 30;
        
    }

    void Update()
    {
        characterManager.ChangeChar();
        uiManager.OpenPanels();

        if (uiManager.inventoryPanel.InventoryPanelOpen == true)
        {
            InventoryPanelOpened();
        }

        if (uiManager.inventoryPanel.InventoryPanelOpen == false)
        {
            InventoryPanelClosed();  
        }

        if (uiManager.characterPanel.CharacterPanelOpen == true)
        {
            CharacterPanelOpened();
        }

        if (uiManager.characterPanel.CharacterPanelOpen == false)
        {
            CharacterPanelClosed();
        }

    }

    void InventoryPanelOpened()
    {
        if (goInventoryPanel == null)
        {
            GameObject instance = Instantiate(Resources.Load("InventoryPanel", typeof(GameObject))) as GameObject;

            goInventoryPanel = instance;
        }

        if (goInventoryPanel != null)
        {
            goInventoryPanel.SetActive(true);
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
