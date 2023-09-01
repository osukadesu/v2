using UnityEngine;
public class InventoryUIA2 : MonoBehaviour
{
    public GameObject itemSlotPrefab;
    public void OnUpdateInventoryA2()
    {
        foreach (Transform t in transform)
        {
            Destroy(t.transform.gameObject);
        }
        DrawInventory();
    }
    public void DrawInventory()
    {
        foreach (InventoryItem item in InventorySystemA2.instance2.inventoryItems)
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