using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ItemData", menuName = "Level/Item")]
public class item_Robert : ScriptableObject
{
    public string Name = "Item";
    public Sprite Icon;
    public int price = 500;
    public int weight = 5;
    public int strength = 200;
    public int maxAmount = 15;

}
