using UnityEngine;
using System.Collections;

public class Character {

    //public VisualCharacter visualCharacterScript;

    private static string nameBoy;
    private static string nameDog;
    
    private static int hpBoy;
    private static int hpDog;

    private static int mpBoy;
    private static int mpDog;

    private static int defBoy;
    private static int defDog;

    private static int attBoy;
    private static int attDog;

    public string NameBoy { get { return nameBoy; } set { nameBoy = value; } }
    public string NameDog { get; set; }

    public int HpBoy { get { return hpBoy; } set { hpBoy = value; } }
    public int HpDog { get { return hpDog; } set { hpDog = value; } }
    
    public int MpBoy { get; set; }
    public int MpDog { get; set; }
    public int DefBoy { get; set; }
    public int DefDog { get; set; }

    
    //default constructor for Character
    public Character()
    {
        
        nameBoy = "Michael";
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
