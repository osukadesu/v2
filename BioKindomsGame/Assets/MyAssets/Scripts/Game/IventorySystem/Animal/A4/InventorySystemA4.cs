using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InventorySystemA4 : MonoBehaviour
{
    public static InventorySystemA4 instance4;
    public delegate void onInventoryChangedEvent();
    public event onInventoryChangedEvent onInventoryChangedEventCallBack;
    public Dictionary<InventoryItemData, InventoryItem> _itemDictionary;
    public List<InventoryItem> inventoryItems;
    [SerializeField] InventoryUIA4 inventoryUIA4;
    void Start()
    {
        instance4.onInventoryChangedEventCallBack += inventoryUIA4.OnUpdateInventoryA4;
    }
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        inventoryItems = new List<InventoryItem>();
        _itemDictionary = new Dictionary<InventoryItemData, InventoryItem>();
        instance4 = this;
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