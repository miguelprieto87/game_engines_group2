using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelPopulator : MonoBehaviour
{
    //public GameObject itemPrefab; //The prefab holding the data for each of the items 
    //public Transform myContainer; //The container where all of the itemPrefabs will appear within the inventory panel

    public GameObject itemsOb;

    //ItemController items;
    public List<ItemSO> itemsSo;

    public List<Image> imageContainers;
    

    // Start is called before the first frame update
    void Start()
    {
        //itemsSo = this.GetComponent<ItemController>().itemsSo;      
    }

    public void PopulateContent(int op)
    {
        try
        {
            Debug.Log("Button: " + op);
            int d = itemsOb.GetComponent<ItemController>().itemsSo.Count;
            //int d = itemsOb.GetComponent<ItemController>().itemsSo.Count;
            Debug.Log("items: " + d);
        }
        catch (System.Exception)
        {
            Debug.Log("ni monda");
            //throw;
        }

        int pos = 0;
        foreach (ItemSO itSo in itemsSo) 
        {
            if (itSo.type == op) 
            {
                Debug.Log("id: " + itSo.id.ToString());
                Debug.Log("pos:" + pos);
                imageContainers[pos].sprite = itSo.itemImage;                
                pos++;
            }
            
        }
        //Increments a for loop until it reaches the maximum amount of items in a list
        //for (int i = 0; i < itemsSo.Count; i++)
        //{
        //    Debug.Log("Item No: " + i);
        //    //Instantiates the itemPrefab within myContainer
        //    //GameObject tempItem = Instantiate(itemPrefab, myContainer);
        //    //ItemController tempController = tempItem.GetComponent<ItemController>();

        //    //Sets the text and image of the itemPrefab to what is found in scriptable objects
        //    //tempController.itemText = items.helmetList[i].itemName;
        //    //tempController.itemImage = items.helmetList[i].itemImage;
        //}
    }

    public void Message() 
    {
        Debug.Log("Message");
    }

   // public void myDataCreation
}
