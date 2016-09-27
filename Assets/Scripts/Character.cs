using UnityEngine;
using System.Collections;

public class Character {

    public VisualCharacter visualCharacterScript;

    private string nameBoy;
    private string nameDog;

    private int hpBoy;
    private int hpDog;

    private int mpBoy;
    private int mpDog;

    private int defBoy;
    private int defDog;


    public string NameBoy { get; set; }
    public string NameDog { get; set; }

    public int HpBoy { get; set; }
    public int HpDob { get; set; }
    public int MpBoy { get; set; }
    public int MpDog { get; set; }
    public int DefBoy { get; set; }
    public int DefBDog { get; set; }


    void Start()
    {
        nameBoy = "Mihael";
        nameDog = "Rufus";
        hpBoy = 30;
        hpDog = 60;
        mpBoy = 0;
        mpDog = 0;
        //weapon
        //stats
        //level
        //att
        defBoy = 0;
        defDog = 0;
    }

    

}
