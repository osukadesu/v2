using UnityEngine;
public class InventoryUIA4 : MonoBehaviour
{
    public GameObject itemSlotPrefab;
    public void OnUpdateInventoryA4()
    {
        foreach (Transform t in transform)
        {
            Destroy(t.transform.gameObject);
        }
        DrawInventory();
    }
    public void DrawInventory()
    {
        foreach (InventoryItem item in InventorySystemA4.instance4.inventoryItems)
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