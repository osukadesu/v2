using UnityEngine;
using UnityEngine.UI;
public class ItemSlot : MonoBehaviour
{
    [SerializeField] Text textName;
    [SerializeField] Image imageTicket, imageItem, imageCheck;
    public void Set(InventoryItem item)
    {
        textName.text = item.inventoryItemData.itemName;
        imageTicket.sprite = item.inventoryItemData.itemTicket[0];
        imageItem.sprite = item.inventoryItemData.itemIcon[0];
        imageCheck.sprite = item.inventoryItemData.itemChecks[0];
    }
}