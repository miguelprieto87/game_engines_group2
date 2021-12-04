using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/EquippableItem", order = 1)]
public class ItemSO : ScriptableObject
{
    //Creates scriptable object that holds a name and a Sprite representing it
    public string itemName;

    public Sprite itemImage;
}
