using UnityEngine;
[CreateAssetMenu(fileName = "Inventory Item Data", menuName = "Inventory System/Create Item", order = 0)]
[System.Serializable]
public class InventoryItemData : ScriptableObject
{
    public string itemName;
    public Sprite[] itemTicket;
    public Sprite[] itemIcon;
    public Sprite[] itemChecks;
    public bool itemIsCheck;
}