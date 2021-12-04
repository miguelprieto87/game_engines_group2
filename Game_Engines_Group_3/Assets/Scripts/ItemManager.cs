using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{ 

    //Holds each of the Images on the canvas where the Sprites from the ItemSO script will be displayed
    public Image helmetIcon;
    public Image torsoIcon;
    public Image glovesIcon;
    public Image leggingsIcon;
    public Image bootsIcon;
    public Image weaponIcon;
    public Image shieldIcon;
    public Image ringIcon;

    //This is the inventory panel that will open and close 
    public GameObject inventoryPanel;

    // Start is called before the first frame update
    void Awake()
    {
        //Upon awake, the inventory panel will be turned off
        inventoryPanel.SetActive(false);
    }

    public void OnButtonPress()
    {
        //When one of the eight buttons is pressed, the inventory panel will appear
        inventoryPanel.SetActive(true);
    }

    public void ExitInventory()
    {
        //When the close button on the inventory panel is selected (Or when an item is selected) the inventory panel will close
        inventoryPanel.SetActive(false);
    }
}
