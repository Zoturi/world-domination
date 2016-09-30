using UnityEngine;
using System.Collections;

public class Character {

    //name
    private static string nameBoy;
    private static string nameDog;
    //hp
    private static int hpBoy;
    private static int hpDog;
    //mp
    private static int mpBoy;
    private static int mpDog;
    //def
    private static int defBoy;
    private static int defDog;
    //att
    private static int attBoy;
    private static int attDog;
    //lvl
    private static int lvlBoy;
    private static int lvlDog;
    //armor
    private static Armor.armorType armorBoy;
    private static Armor.armorType armorDog;

    //properties for values
    //name
    public string NameBoy { get { return nameBoy; } set { nameBoy = value; } }
    public string NameDog { get { return nameDog; } set { nameDog = value; } }
    //hp
    public int HpBoy { get { return hpBoy; } set { hpBoy = value; } }
    public int HpDog { get { return hpDog; } set { hpDog = value; } }
    //mp
    public int MpBoy { get { return mpBoy; } set { mpBoy = value; } }
    public int MpDog { get { return mpDog; } set { mpDog = value; } }
    //def
    public int DefBoy { get { return defBoy; } set { defBoy = value; } }
    public int DefDog { get { return defDog; } set { defDog = value; } }
    //att
    public int AttBoy { get { return attBoy; } set { attBoy = value; } }
    public int AttDog { get { return attDog; } set { attDog = value; } }
    //lvl
    public int LvlBoy { get { return lvlBoy; } set { lvlBoy = value; } }
    public int LvlDog { get { return lvlDog; } set { lvlDog = value; } }
    //armor
    public Armor.armorType ArmorBoy { get { return armorBoy; } set { armorBoy = value; } }

    public Armor.armorType ArmorDog { get { return armorDog; } set { armorDog = value; } }


    //default constructor for Character
    public Character()
    {
        
        nameBoy = "Mike";
        nameDog = "Rufus";
        hpBoy = 30;
        hpDog = 60;
        mpBoy = 0;
        mpDog = 0;
        defBoy = 2;
        defDog = 5;
        attBoy = 4;
        attDog = 7;
        lvlBoy = 1;
        lvlDog = 1;
        armorBoy = Armor.armorType.elemental; //this is changed in gamemanager to steel, as an example
        armorDog = Armor.armorType.leather;
        
    }

    

}
