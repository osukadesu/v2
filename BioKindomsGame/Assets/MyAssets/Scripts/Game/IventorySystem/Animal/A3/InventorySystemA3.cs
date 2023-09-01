using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InventorySystemA3 : MonoBehaviour
{
    public static InventorySystemA3 instance3;
    public delegate void onInventoryChangedEvent();
    public event onInventoryChangedEvent onInventoryChangedEventCallBack;
    public Dictionary<InventoryItemData, InventoryItem> _itemDictionary;
    public List<InventoryItem> inventoryItems;
    [SerializeField] InventoryUIA3 inventoryUIA3;
    void Start()
    {
        instance3.onInventoryChangedEventCallBack += inventoryUIA3.OnUpdateInventoryA3;
    }
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        inventoryItems = new List<InventoryItem>();
        _itemDictionary = new Dictionary<InventoryItemData, InventoryItem>();
        instance3 = this;
    }
    public void Add(InventoryItemData referenceData)
    {
        if (_itemDictionary.TryGetValue(referenceData, out InventoryItem value))
        {
            value.AddStack();
            onInventoryChangedEventCallBack.Invoke();
        }
        else
        {
            InventoryItem newItem = new InventoryItem(referenceData);
            inventoryItems.Add(newItem);
            _itemDictionary.Add(referenceData, newItem);
            onInventoryChangedEventCallBack.Invoke();
        }
    }
}