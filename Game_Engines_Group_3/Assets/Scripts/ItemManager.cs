using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public List<ItemSO> helmetList;
    public List<ItemSO> torsoList;
    public List<ItemSO> glovesList;
    public List<ItemSO> leggingsList;
    public List<ItemSO> bootsList;
    public List<ItemSO> weaponList;
    public List<ItemSO> shieldList;
    public List<ItemSO> ringList;

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
}
