using UnityEngine;
public class InventoryUIA5 : MonoBehaviour
{
    public GameObject itemSlotPrefab;
    public void OnUpdateInventoryA5()
    {
        foreach (Transform t in transform)
        {
            Destroy(t.transform.gameObject);
        }
        DrawInventory();
    }
    public void DrawInventory()
    {
        foreach (InventoryItem item in InventorySystemA5.instance5.inventoryItems)
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