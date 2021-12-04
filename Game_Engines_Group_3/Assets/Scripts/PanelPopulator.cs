using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelPopulator : MonoBehaviour
{
    public GameObject itemPrefab;
    public Transform myContainer;

    public CheckButton button;

    public List<ItemSO> helmetList;
    public List<ItemSO> torsoList;
    public List<ItemSO> glovesList;
    public List<ItemSO> leggingsList;
    public List<ItemSO> bootsList;
    public List<ItemSO> weaponList;
    public List<ItemSO> shieldList;
    public List<ItemSO> ringList;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PopulateContent()
    {
        for(int i = 0; i < helmetList.Count; i++)
        {

        }
    }
}
