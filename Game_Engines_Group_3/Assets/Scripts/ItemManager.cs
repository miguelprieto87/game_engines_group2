using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{ 

    //Holds each of the Images on the canvas where the Sprites from the ItemSO script will be displayed
    public Image helmetIcon;
    public Image torsoIcon;
    //public Image glovesIcon;
    public Image leggingsIcon;
    public Image bootsIcon;
    public Image weaponIcon;
    public Image shieldIcon;
    public Image ringIcon;

    public ItemSO itemSO;

    //public List<Image> imageContainers;

    //This is the inventory panel that will open and close 
    //public GameObject inventoryPanel;

    // Start is called before the first frame update
    void Awake()
    {
        //Upon awake, the inventory panel will be turned off
        //inventoryPanel.SetActive(false);
        helmetIcon = GameObject.FindGameObjectWithTag("helmet").GetComponent<Image>();
        torsoIcon = GameObject.FindGameObjectWithTag("armour").GetComponent<Image>();
        leggingsIcon = GameObject.FindGameObjectWithTag("leggins").GetComponent<Image>();
        bootsIcon = GameObject.FindGameObjectWithTag("boots").GetComponent<Image>();
        weaponIcon = GameObject.FindGameObjectWithTag("weapon").GetComponent<Image>();
        shieldIcon = GameObject.FindGameObjectWithTag("shield").GetComponent<Image>();
        ringIcon = GameObject.FindGameObjectWithTag("ring").GetComponent<Image>();        
    }

    public void setImageToCharacter() 
    {
        int type = itemSO.type;

        switch (type) 
        {
            case 1:
                torsoIcon.sprite = itemSO.itemImage;
                PlayerPrefs.SetInt("armour",itemSO.id);
                break;
            case 2:
                PlayerPrefs.SetInt("boots", itemSO.id);
                bootsIcon.sprite = itemSO.itemImage;
                break;
            case 3:
                PlayerPrefs.SetInt("helmet", itemSO.id);
                helmetIcon.sprite = itemSO.itemImage;
                break;
            case 4:
                PlayerPrefs.SetInt("leggins", itemSO.id);
                leggingsIcon.sprite = itemSO.itemImage;
                break;
            case 5:
                PlayerPrefs.SetInt("ring", itemSO.id);
                ringIcon.sprite = itemSO.itemImage;
                break;
            case 6:
                PlayerPrefs.SetInt("shield", itemSO.id);
                shieldIcon.sprite = itemSO.itemImage;
                break;
            case 7:
                PlayerPrefs.SetInt("weapon", itemSO.id);
                weaponIcon.sprite = itemSO.itemImage;
                break;


        }
    }

    #region OldFunctions

    public void OnButtonPress()
    {
        //When one of the eight buttons is pressed, the inventory panel will appear
        //inventoryPanel.SetActive(true);

    }

    public void ExitInventory()
    {
       // ClearHolders();
        //When the close button on the inventory panel is selected (Or when an item is selected) the inventory panel will close
        //inventoryPanel.SetActive(false);
    }

    //public void ClearHolders()
    //{
    //    int pos = 0;
    //    for (int i = 0; i < imageContainers.Count; i++)
    //    {
    //        imageContainers[pos].sprite = null;
    //        pos++;
    //    }
    //}
    #endregion


}
