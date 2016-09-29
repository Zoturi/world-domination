using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Text nameTextBoy;
    public Text nameTextDog;

    public Text hpTextBoy;
    public Text hpTextDog;

    void Update()
    {
        nameTextBoy.text = GameManager.instance.character.NameBoy.ToString();
        nameTextDog.text = GameManager.instance.character.NameDog.ToString();

        hpTextBoy.text = "Health: " + GameManager.instance.character.HpBoy.ToString();
        hpTextDog.text = "Health: " + GameManager.instance.character.HpDog.ToString();

        if (Input.GetKeyDown(KeyCode.T))
        {
            GameManager.instance.character.HpBoy = GameManager.instance.character.HpBoy - 1;
        }
    }
        
}
