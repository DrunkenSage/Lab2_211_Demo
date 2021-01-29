using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAvatar : MonoBehaviour
{
    public string playerName2;
    public CanvasGroup StatsScreen;
    public Text tellPlayer;
    public Slider FaceColor;
    public Slider WeaponPick;
    
    public Image Face;
    public Image Weapon;

    public Sprite Gun;
    public Sprite Grenade;
    public Sprite Sword;

    Color32[] Colors; // create an array to hold colors
    
    private void Awake()
    {
        Colors = new Color32[4];
        Colors[0] = new Color32(185, 0, 185, 255);
        Colors[1] = new Color32(0, 127, 255, 255);
        Colors[2] = new Color32(0, 0, 255, 255);
        Colors[3] = new Color32(0, 255, 255, 255);

        

        playerName2= PlayerPrefs.GetString("ThisPlayer", "playerName");
        tellPlayer.text = "Hi " + playerName2;
        Debug.Log(playerName2 + "is");
    }

    // use slider to change color of face
    public void changeFace()
    {
        float newFaceValue = FaceColor.value; // grab the value of the slider
       
        Face.color = Colors[(int)newFaceValue]; // use it to pick a color from array
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
        } else if(newWeaponValue == 2)
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
