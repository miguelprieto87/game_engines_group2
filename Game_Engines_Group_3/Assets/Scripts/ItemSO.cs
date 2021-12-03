using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/EquippableItem", order = 1)]
public class ItemSO : ScriptableObject
{
    public string itemName;

    public Image itemImage;
}
