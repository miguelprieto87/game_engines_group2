using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelPopulator : MonoBehaviour
{
    //public GameObject inventoryLinePrefab; //The prefab holding the data for a maximun of 4 elements
    public GameObject itemHolderPrefab; //The prefab holding the data for a single element
    public Transform myContainer; //The container where all of the itemPrefabs will appear within the inventory panel

    public GameObject itemsOb;

    //ItemController items;
    //public List<ItemSO> itemsSo;

    //public List<Image> imageContainers;
    

    // Start is called before the first frame update
    void Start()
    {
        //itemsSo = this.GetComponent<ItemController>().itemsSo;      
    }
    private void Awake()
    {
        populateAllInvetory();
    }



    public void Message() 
    {
        Debug.Log("Message");
    }



    public void populateAllInvetory() 
    {
        try
        {
            DeleteChildren();
            foreach (ItemSO itSo in itemsOb.GetComponent<ItemController>().itemsSo)//foreach (ItemSO itSo in itemsSo)
            {
                createItemHolder(myContainer, itSo);
            }               

        }
        catch (System.Exception)
        {

            throw;
        }
    }

    public void populateInventory(int op)
    {
       
        try
        {
            DeleteChildren();
            foreach (ItemSO itSo in itemsOb.GetComponent<ItemController>().itemsSo)//foreach (ItemSO itSo in itemsSo)
            {
                if (itSo.type == op) 
                {
                    createItemHolder(myContainer,itSo);               
                }

            }

        }
        catch (System.Exception)
        {

            throw;
        }       
                
    }



    void createItemHolder(Transform parent, ItemSO itemSO)
    {
        GameObject myPrefabItem = Instantiate(itemHolderPrefab, parent.transform);
        myPrefabItem.GetComponent<Image>().sprite = itemSO.itemImage;
        myPrefabItem.GetComponent<ItemManager>().itemSO = itemSO;
    }

    public void DeleteChildren() 
    {
        int count = myContainer.childCount;
        //myContainer.GetChild();
        if (count!=0) 
        {
            for (int i = 0; i < count; i++)
            {
                Destroy(myContainer.GetChild(i).gameObject);
            }
        }
        
        //Debug.Log("childrens: "+ count );

        
    }

    public void ShowPlayerPrefs() 
    {
        Debug.Log(PlayerPrefs.GetInt("armour").ToString());
        Debug.Log(PlayerPrefs.GetInt("boots").ToString());
        Debug.Log(PlayerPrefs.GetInt("helmet").ToString());
        Debug.Log(PlayerPrefs.GetInt("leggins").ToString());
        Debug.Log(PlayerPrefs.GetInt("ring").ToString());
        Debug.Log(PlayerPrefs.GetInt("shield").ToString());
        Debug.Log(PlayerPrefs.GetInt("weapon").ToString());
    }
   
}


/*trash code
 * 
 *  public void PopulateContent(int op)
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
 * 
 * public void SetLevelInventory(int op) 
    {
        createLevelInventory(op);
    }
 * 
    GameObject createSubLevel() 
    {
        GameObject myPrefabLine = Instantiate(inventoryLinePrefab, myContainer);
        return myPrefabLine;
    }

 //int pos = 0;
            //GameObject subLevel = createSubLevel();
            //int lvlLine=0;
            //bool sw = false;
 * //GameObject myPrefabLine = Instantiate(inventoryLinePrefab, myContainer);


        //GameObject myPrefabItem = Instantiate(itemHolderPrefab, myPrefabLine.transform);
        //GameObject myPrefabItem2 = Instantiate(itemHolderPrefab, myPrefabLine.transform);
        //GameObject myPrefabItem3 = Instantiate(itemHolderPrefab, myPrefabLine.transform);
        //GameObject myPrefabItem4 = Instantiate(itemHolderPrefab, myPrefabLine.transform);
 * 
 * 
 *  if (itSo.type == op)
                {
                    if (lvlLine == 4)
                    {
                        sw = true;
                        lvlLine = 0;
                    }

                    if (sw == true)
                    {
                        subLevel = createSubLevel();
                        createItemHolder(subLevel,itSo);
                        sw = false;
                        lvlLine++;
                    }
                    else
                    {
                        createItemHolder(subLevel, itSo);
                        lvlLine++;
                    }
                    


                    Debug.Log("id: " + itSo.id.ToString());
                    Debug.Log("pos:" + pos);
                    //imageContainers[pos].sprite = itSo.itemImage;
                    pos++;
                }
 
 
 */