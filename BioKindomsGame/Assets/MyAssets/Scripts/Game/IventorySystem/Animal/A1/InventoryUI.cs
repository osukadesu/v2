using UnityEngine;
public class InventoryUI : MonoBehaviour
{
    public GameObject itemSlotPrefab;
    public void OnUpdateInventory()
    {
        foreach (Transform t in transform)
        {
            Destroy(t.transform.gameObject);
        }
        DrawInventory();
    }
    public void DrawInventory()
    {
        foreach (InventoryItem item in InventorySystem.instance.inventoryItems)
        {
            AddInventorySlot(item);
        }
    }
    public void AddInventorySlot(InventoryItem item)
    {
        GameObject obj = Instantiate(itemSlotPrefab);
        obj.transform.SetParent(transform, false);
        ItemSlot slot = obj.GetComponent<ItemSlot>();
        slot.Set(item);
    }
}