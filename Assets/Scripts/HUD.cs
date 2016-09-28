using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {

    
    void OnGUI()
    {
        int test = 10;
        GameManager.instance.character.HpDog = test;


        //change these to UI text for health and mana
        //kesken

        float cameraPixelHeight = Camera.main.pixelHeight;
        float cameraPixelWidth = Camera.main.pixelWidth;

        GUI.Label(new Rect(cameraPixelWidth / 11f, cameraPixelHeight / 1.2f, 150, 30), "Boy Health: " + GameManager.instance.character.HpBoy);
        GUI.Label(new Rect(cameraPixelWidth / 2f, cameraPixelHeight / 1.2f, 150, 30), "Dog Health: " + GameManager.instance.character.HpDog);
        
    }
}
