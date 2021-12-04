using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{ 

    public Image helmetIcon;
    public Image torsoIcon;
    public Image glovesIcon;
    public Image leggingsIcon;
    public Image bootsIcon;
    public Image weaponIcon;
    public Image shieldIcon;
    public Image ringIcon;

    public GameObject inventoryPanel;

    // Start is called before the first frame update
    void Awake()
    {
        inventoryPanel.SetActive(false);
    }

    public void OnButtonPress()
    {
        inventoryPanel.SetActive(true);
    }

    public void ExitInventory()
    {
        inventoryPanel.SetActive(false);
    }
}
