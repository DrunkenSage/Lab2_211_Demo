using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{

    public string playerName2; // string to hold playername from Title screen
    public CanvasGroup StatsScreen; // ref to hold panel group
    public Text tellPlayer;  // text field where we put player name
    public Slider FaceColor;  // reference to first slider
    public Slider WeaponPick; // ref to weapon slider

    public Image Face;  // ref to image holding avatar face
    public Image Weapon; // ref to image holding weapon type

    public Sprite Gun;
    public Sprite Grenade;
    public Sprite Sword;

    Color32[] Colors; // array to hold colors we provide the player

    // Start is called before the first frame update
    void Awake()
    {
        playerName2 = PlayerPrefs.GetString("ThisPlayer", "playerName");
        tellPlayer.text = "Hi " + playerName2;

        Colors = new Color32[4];
        Colors[0] = new Color32(185, 0, 185, 255);
        Colors[1] = new Color32(0, 127, 255, 255);
        Colors[2] = new Color32(0, 0, 255, 255);
        Colors[3] = new Color32(0, 255, 255, 255);

    }

    // function that changes the color of the avatar image

    public void changeFace()
    {
        float newFaceValue = FaceColor.value; // sets the float to the current value of slider
        Face.color = Colors[(int)newFaceValue];
    }

    public void changeWeapon()
    {

        float newWeaponValue = WeaponPick.value;
        if(newWeaponValue == 0)
        {
            Weapon.sprite = Gun;

        } else if (newWeaponValue == 1)
        {
            Weapon.sprite = Grenade;
        } else if (newWeaponValue== 2)
        {
            Weapon.sprite = Sword;
        }
    }

    public void closePanel()
    {
        StatsScreen.alpha = 0f;
        StatsScreen.interactable = false;
        StatsScreen.blocksRaycasts = false;
    }

}
