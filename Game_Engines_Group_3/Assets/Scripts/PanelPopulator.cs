using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelPopulator : MonoBehaviour
{
    public GameObject itemPrefab; //The prefab holding the data for each of the items 
    public Transform myContainer; //The container where all of the itemPrefabs will appear within the inventory panel

    ItemController items;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PopulateContent()
    {
        //Increments a for loop until it reaches the maximum amount of items in a list
        for(int i = 0; i < items.helmetList.Count; i++)
        {
            //Instantiates the itemPrefab within myContainer
            GameObject tempItem = Instantiate(itemPrefab, myContainer);
            ItemController tempController = tempItem.GetComponent<ItemController>();

            //Sets the text and image of the itemPrefab to what is found in scriptable objects
            //tempController.itemText = items.helmetList[i].itemName;
            //tempController.itemImage = items.helmetList[i].itemImage;
        }
    }

   // public void myDataCreation
}
