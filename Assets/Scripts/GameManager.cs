using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    private static CharacterPanel _charPanelInstance;

    private static UIManager _uiManagerInstance;

    public static CharacterPanel CharPanelInstance
    {
        get
        {
            //Logic for creating CharacterPanel
            if (_charPanelInstance == null)
            {
                GameObject go = new GameObject("Character Panel");
                go.AddComponent<CharacterPanel>();
            }

            return _charPanelInstance;
        }
    }

    public static UIManager UIManagerInstance
    {
        get
        {
            //Logic for creating UIManager
            if (_uiManagerInstance == null)
            {
                GameObject go = new GameObject("UI Manager");
                go.AddComponent<UIManager>();
            }

            return _uiManagerInstance;
        }
    }
    public bool isAlive { get; set; }

    void Awake()
    {
        _charPanelInstance = CharPanelInstance;
        _uiManagerInstance = UIManagerInstance;
    }

    void Start()
    {
        isAlive = true;
    }
}
